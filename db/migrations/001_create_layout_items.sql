-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, weight, ratio, region, score) VALUES (21, 66.38, 5.12, 'green', 44.17);
INSERT INTO layout_items (rank, weight, ratio, region, score) VALUES (82, 70.83, 8.06, 'latest', 89.52);
