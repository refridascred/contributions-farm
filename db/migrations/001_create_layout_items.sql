-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, region, count, score) VALUES (49, 'legacy', 49, 4.4);
INSERT INTO layout_items (rank, region, count, score) VALUES (17, 'edge', 91, 5.14);
INSERT INTO layout_items (rank, region, count, score) VALUES (13, 'standard', 86, 28.61);
