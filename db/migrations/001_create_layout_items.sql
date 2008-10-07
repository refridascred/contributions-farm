-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, token, rank, weight) VALUES (16, 'primary', 6, 13.55);
INSERT INTO layout_items (count, token, rank, weight) VALUES (18, 'edge', 30, 38.76);
INSERT INTO layout_items (count, token, rank, weight) VALUES (65, 'strict', 47, 19.08);
