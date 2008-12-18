-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, score, region, count, weight) VALUES (57.33, 15.98, 'standard', 89, 92.52);
INSERT INTO layout_items (ratio, score, region, count, weight) VALUES (5.83, 53.35, 'standard', 66, 3.24);
