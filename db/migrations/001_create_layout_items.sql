-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, ratio, label) VALUES (33.89, 45.83, 'local');
INSERT INTO layout_items (weight, ratio, label) VALUES (3.61, 4.73, 'latest');
