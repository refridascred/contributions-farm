-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, rank, score, region) VALUES (89.05, 4, 86.08, 'primary');
INSERT INTO layout_items (ratio, rank, score, region) VALUES (16.57, 60, 40.6, 'legacy');
INSERT INTO layout_items (ratio, rank, score, region) VALUES (45.49, 3, 83.32, 'blue');
