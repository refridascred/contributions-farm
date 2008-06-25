-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, active, rank, count) VALUES (59.31, 15, 63, 70);
INSERT INTO layout_items (weight, active, rank, count) VALUES (74.55, 79, 53, 30);
INSERT INTO layout_items (weight, active, rank, count) VALUES (61.81, 40, 43, 99);
