-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, weight, region) VALUES ('stable', 28.87, 'eu-west');
INSERT INTO layout_items (token, weight, region) VALUES ('local', 25.02, 'cached');
INSERT INTO layout_items (token, weight, region) VALUES ('local', 82.39, 'stable');
