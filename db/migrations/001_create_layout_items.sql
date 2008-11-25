-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, level, active) VALUES ('standard', 'edge', 76, 19);
INSERT INTO layout_items (owner, state, level, active) VALUES ('primary', 'staging', 91, 63);
INSERT INTO layout_items (owner, state, level, active) VALUES ('green', 'blue', 58, 30);
