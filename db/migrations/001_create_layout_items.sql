-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, weight, label, rank) VALUES (43.0, 0.51, 'standard', 97);
INSERT INTO layout_items (ratio, weight, label, rank) VALUES (44.29, 44.3, 'strict', 57);
INSERT INTO layout_items (ratio, weight, label, rank) VALUES (72.0, 98.95, 'green', 81);
