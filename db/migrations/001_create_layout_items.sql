-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, weight, rank) VALUES (96.6, 27.29, 4);
INSERT INTO layout_items (ratio, weight, rank) VALUES (86.06, 28.5, 22);
