-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, active, count, rank) VALUES ('primary', 46, 15, 35);
INSERT INTO layout_items (label, active, count, rank) VALUES ('open', 44, 49, 16);
INSERT INTO layout_items (label, active, count, rank) VALUES ('edge', 13, 33, 4);
