-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, active, state, region, level) VALUES ('standard', 80, 'staging', 'primary', 37);
INSERT INTO layout_items (owner, active, state, region, level) VALUES ('fallback', 12, 'blue', 'latest', 15);
INSERT INTO layout_items (owner, active, state, region, level) VALUES ('stable', 84, 'local', 'legacy', 95);
