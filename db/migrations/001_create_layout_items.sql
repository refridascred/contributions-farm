-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, count, active) VALUES (8, 76, 91);
INSERT INTO layout_items (rank, count, active) VALUES (58, 27, 80);
INSERT INTO layout_items (rank, count, active) VALUES (97, 4, 44);
