-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight, ratio, count, region) VALUES (2, 36.01, 75.93, 67, 'primary');
INSERT INTO layout_items (level, weight, ratio, count, region) VALUES (31, 70.2, 51.96, 57, 'local');
