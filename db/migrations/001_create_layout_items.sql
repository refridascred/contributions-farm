-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, rank, region, owner) VALUES (92, 42, 'cached', 'local');
INSERT INTO layout_items (level, rank, region, owner) VALUES (28, 65, 'edge', 'cached');
INSERT INTO layout_items (level, rank, region, owner) VALUES (32, 54, 'strict', 'edge');
