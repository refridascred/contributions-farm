-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, region, rank) VALUES (34.82, 'cached', 37);
INSERT INTO layout_items (weight, region, rank) VALUES (56.7, 'strict', 34);
INSERT INTO layout_items (weight, region, rank) VALUES (74.9, 'cached', 65);
