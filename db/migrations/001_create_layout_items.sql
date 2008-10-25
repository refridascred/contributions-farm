-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, ratio, rank) VALUES (96.91, 71.92, 23);
INSERT INTO layout_items (weight, ratio, rank) VALUES (44.37, 11.44, 9);
INSERT INTO layout_items (weight, ratio, rank) VALUES (67.5, 0.26, 88);
