-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, region, label) VALUES (73.7, 'staging', 'open');
INSERT INTO layout_items (weight, region, label) VALUES (36.67, 'edge', 'eu-west');
