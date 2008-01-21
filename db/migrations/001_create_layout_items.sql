-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (active, weight, ratio) VALUES (17, 95.97, 39.07);
INSERT INTO layout_items (active, weight, ratio) VALUES (49, 69.62, 4.72);
INSERT INTO layout_items (active, weight, ratio) VALUES (65, 7.72, 38.76);
