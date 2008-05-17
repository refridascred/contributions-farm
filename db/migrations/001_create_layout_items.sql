-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, region, count, ratio, label) VALUES (28.39, 'stable', 4, 18.83, 'blue');
INSERT INTO layout_items (weight, region, count, ratio, label) VALUES (40.38, 'green', 11, 40.45, 'local');
INSERT INTO layout_items (weight, region, count, ratio, label) VALUES (51.4, 'cached', 34, 56.58, 'blue');
