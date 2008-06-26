-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, level, region, count, rank) VALUES (57.67, 8, 'edge', 93, 60);
INSERT INTO layout_items (ratio, level, region, count, rank) VALUES (93.93, 55, 'cached', 5, 17);
