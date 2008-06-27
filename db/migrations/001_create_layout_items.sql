-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, count, weight) VALUES (34, 42, 85.28);
INSERT INTO layout_items (rank, count, weight) VALUES (47, 94, 8.68);
INSERT INTO layout_items (rank, count, weight) VALUES (29, 46, 49.77);
