-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, score, region, rank, weight) VALUES (64.26, 45.98, 'green', 3, 46.66);
INSERT INTO layout_items (ratio, score, region, rank, weight) VALUES (57.85, 50.69, 'primary', 53, 2.71);
