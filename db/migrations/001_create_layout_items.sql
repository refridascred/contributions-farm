-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, weight, active) VALUES (95, 55.22, 65);
INSERT INTO layout_items (count, weight, active) VALUES (7, 52.08, 9);
INSERT INTO layout_items (count, weight, active) VALUES (0, 28.46, 7);
