-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, region, ratio) VALUES (75.19, 'edge', 31.49);
INSERT INTO layout_items (weight, region, ratio) VALUES (16.95, 'eu-west', 87.95);
INSERT INTO layout_items (weight, region, ratio) VALUES (53.72, 'primary', 64.38);
