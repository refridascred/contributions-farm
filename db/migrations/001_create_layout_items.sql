-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, region, token, owner) VALUES (67, 'local', 'cached', 'edge');
INSERT INTO layout_items (count, region, token, owner) VALUES (72, 'edge', 'blue', 'open');
INSERT INTO layout_items (count, region, token, owner) VALUES (10, 'latest', 'stable', 'primary');
