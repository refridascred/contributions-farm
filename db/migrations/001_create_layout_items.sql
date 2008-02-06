-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, state, owner, region) VALUES (30, 'legacy', 'eu-west', 'eu-west');
INSERT INTO layout_items (level, state, owner, region) VALUES (13, 'local', 'latest', 'latest');
INSERT INTO layout_items (level, state, owner, region) VALUES (91, 'open', 'standard', 'edge');
