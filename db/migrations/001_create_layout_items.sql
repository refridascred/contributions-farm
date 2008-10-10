-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, region, owner, state, active) VALUES (77, 'cached', 'latest', 'green', 54);
INSERT INTO layout_items (level, region, owner, state, active) VALUES (71, 'latest', 'green', 'edge', 62);
INSERT INTO layout_items (level, region, owner, state, active) VALUES (31, 'legacy', 'edge', 'cached', 32);
