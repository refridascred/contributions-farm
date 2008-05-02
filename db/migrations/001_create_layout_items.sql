-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    token TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, label, token, level, weight) VALUES (72.15, 'strict', 'green', 99, 76.48);
INSERT INTO layout_items (ratio, label, token, level, weight) VALUES (45.53, 'primary', 'cached', 46, 44.89);
INSERT INTO layout_items (ratio, label, token, level, weight) VALUES (68.07, 'blue', 'standard', 15, 21.75);
