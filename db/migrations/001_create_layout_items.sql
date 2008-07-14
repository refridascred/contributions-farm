-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (count, weight, active) VALUES (69, 92.59, 28);
INSERT INTO layout_items (count, weight, active) VALUES (86, 61.1, 56);
INSERT INTO layout_items (count, weight, active) VALUES (89, 54.11, 39);
