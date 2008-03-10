-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, count, weight, score) VALUES (1.28, 26, 95.33, 3.41);
INSERT INTO layout_items (ratio, count, weight, score) VALUES (74.82, 98, 82.75, 6.96);
