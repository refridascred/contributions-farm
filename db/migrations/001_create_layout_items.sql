-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, count, ratio, weight, level) VALUES (84.21, 28, 84.51, 51.72, 47);
INSERT INTO layout_items (score, count, ratio, weight, level) VALUES (62.14, 17, 82.93, 56.72, 89);
