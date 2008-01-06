-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, ratio, rank) VALUES (48, 67.15, 35);
INSERT INTO layout_items (count, ratio, rank) VALUES (53, 15.77, 71);
INSERT INTO layout_items (count, ratio, rank) VALUES (56, 61.49, 40);
