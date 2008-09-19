-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, region, ratio) VALUES (31.77, 'edge', 66.35);
INSERT INTO layout_items (weight, region, ratio) VALUES (45.93, 'fallback', 62.68);
INSERT INTO layout_items (weight, region, ratio) VALUES (39.25, 'fallback', 58.97);
