-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, count, ratio) VALUES (36.95, 89, 44.34);
INSERT INTO layout_items (weight, count, ratio) VALUES (21.99, 83, 20.19);
INSERT INTO layout_items (weight, count, ratio) VALUES (83.98, 30, 30.4);
