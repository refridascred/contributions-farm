-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (count, active, rank) VALUES (8, 47, 88);
INSERT INTO layout_items (count, active, rank) VALUES (67, 22, 83);
INSERT INTO layout_items (count, active, rank) VALUES (20, 24, 45);
