-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (count, active, rank) VALUES (37, 61, 76);
INSERT INTO layout_items (count, active, rank) VALUES (65, 66, 74);
INSERT INTO layout_items (count, active, rank) VALUES (18, 47, 38);
