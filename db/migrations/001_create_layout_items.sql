-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, active, count) VALUES (45.64, 11, 63);
INSERT INTO layout_items (weight, active, count) VALUES (59.39, 23, 27);
INSERT INTO layout_items (weight, active, count) VALUES (20.17, 14, 58);
