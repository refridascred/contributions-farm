-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, ratio, level, score, count) VALUES (61.52, 33.29, 86, 76.02, 75);
INSERT INTO layout_items (weight, ratio, level, score, count) VALUES (85.91, 35.37, 35, 82.89, 91);
INSERT INTO layout_items (weight, ratio, level, score, count) VALUES (98.11, 85.61, 89, 74.0, 78);
