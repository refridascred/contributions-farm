-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, count, rank) VALUES (56, 3, 8);
INSERT INTO layout_items (active, count, rank) VALUES (86, 91, 9);
INSERT INTO layout_items (active, count, rank) VALUES (31, 21, 11);
