-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, region, weight, rank) VALUES (57, 'blue', 98.44, 52);
INSERT INTO layout_items (count, region, weight, rank) VALUES (32, 'edge', 89.15, 47);
INSERT INTO layout_items (count, region, weight, rank) VALUES (62, 'latest', 96.93, 54);
