-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, ratio, label) VALUES (46.48, 94.12, 'legacy');
INSERT INTO layout_items (weight, ratio, label) VALUES (7.37, 26.76, 'stable');
INSERT INTO layout_items (weight, ratio, label) VALUES (23.01, 28.57, 'stable');
