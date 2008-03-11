-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (count, active, weight) VALUES (5, 95, 46.7);
INSERT INTO layout_items (count, active, weight) VALUES (44, 47, 13.77);
INSERT INTO layout_items (count, active, weight) VALUES (85, 26, 72.13);
