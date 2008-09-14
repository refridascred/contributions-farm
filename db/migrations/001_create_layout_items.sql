-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, region, count, rank, token) VALUES (0.98, 'green', 7, 59, 'edge');
INSERT INTO layout_items (ratio, region, count, rank, token) VALUES (6.66, 'cached', 5, 15, 'latest');
