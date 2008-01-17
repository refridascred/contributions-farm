-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, ratio, region, count, score) VALUES (41.81, 76.88, 'legacy', 67, 69.41);
INSERT INTO layout_items (weight, ratio, region, count, score) VALUES (47.81, 49.41, 'legacy', 50, 34.82);
