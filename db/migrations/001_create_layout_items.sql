-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, rank, count) VALUES (73, 5, 58);
INSERT INTO layout_items (active, rank, count) VALUES (19, 86, 98);
INSERT INTO layout_items (active, rank, count) VALUES (13, 9, 27);
