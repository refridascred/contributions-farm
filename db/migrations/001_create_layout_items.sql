-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, weight, region, ratio) VALUES (42, 13.26, 'edge', 38.39);
INSERT INTO layout_items (rank, weight, region, ratio) VALUES (80, 78.53, 'legacy', 8.13);
