-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, weight, region, label) VALUES (7.63, 39.07, 'eu-west', 'legacy');
INSERT INTO layout_items (ratio, weight, region, label) VALUES (70.67, 21.05, 'cached', 'latest');
INSERT INTO layout_items (ratio, weight, region, label) VALUES (30.64, 38.18, 'blue', 'staging');
