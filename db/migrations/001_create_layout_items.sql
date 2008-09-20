-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, region, rank) VALUES (10.44, 'local', 57);
INSERT INTO layout_items (weight, region, rank) VALUES (98.68, 'primary', 45);
INSERT INTO layout_items (weight, region, rank) VALUES (92.05, 'edge', 8);
