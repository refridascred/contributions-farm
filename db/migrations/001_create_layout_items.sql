-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, label, ratio) VALUES (96.11, 'legacy', 70.1);
INSERT INTO layout_items (weight, label, ratio) VALUES (43.83, 'latest', 32.55);
