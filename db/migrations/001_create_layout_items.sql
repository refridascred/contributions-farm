-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight, ratio, score) VALUES (47, 62.31, 0.23, 10.88);
INSERT INTO layout_items (level, weight, ratio, score) VALUES (54, 41.79, 69.43, 55.24);
INSERT INTO layout_items (level, weight, ratio, score) VALUES (58, 92.23, 50.57, 45.73);
