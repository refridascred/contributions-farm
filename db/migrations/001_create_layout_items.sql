-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (active, level, weight) VALUES (73, 93, 87.09);
INSERT INTO layout_items (active, level, weight) VALUES (7, 12, 54.8);
INSERT INTO layout_items (active, level, weight) VALUES (57, 17, 83.8);
