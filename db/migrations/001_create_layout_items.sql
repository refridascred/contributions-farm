-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, level, count) VALUES (61.06, 70, 45);
INSERT INTO layout_items (weight, level, count) VALUES (97.65, 16, 35);
INSERT INTO layout_items (weight, level, count) VALUES (65.58, 36, 83);
