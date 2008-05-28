-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, score, level, count, region) VALUES (82.4, 82.5, 24, 41, 'cached');
INSERT INTO layout_items (weight, score, level, count, region) VALUES (89.89, 12.49, 29, 78, 'local');
INSERT INTO layout_items (weight, score, level, count, region) VALUES (34.8, 60.82, 28, 1, 'stable');
