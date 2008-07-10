-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, count, ratio, rank, state) VALUES (30.69, 55, 89.32, 11, 'strict');
INSERT INTO layout_items (weight, count, ratio, rank, state) VALUES (83.03, 31, 64.13, 16, 'eu-west');
