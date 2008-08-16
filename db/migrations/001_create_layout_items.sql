-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    level INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, ratio, level, region, label) VALUES (65.6, 81.37, 77, 'blue', 'standard');
INSERT INTO layout_items (weight, ratio, level, region, label) VALUES (89.47, 9.24, 17, 'cached', 'green');
INSERT INTO layout_items (weight, ratio, level, region, label) VALUES (55.69, 68.5, 25, 'blue', 'staging');
