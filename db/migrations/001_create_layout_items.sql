-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, active, weight) VALUES (94, 2, 65.76);
INSERT INTO layout_items (count, active, weight) VALUES (53, 76, 25.32);
INSERT INTO layout_items (count, active, weight) VALUES (73, 0, 48.46);
