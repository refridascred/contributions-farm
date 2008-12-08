-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, state, count, score) VALUES (33, 'open', 7, 8.45);
INSERT INTO layout_items (rank, state, count, score) VALUES (62, 'local', 47, 76.39);
INSERT INTO layout_items (rank, state, count, score) VALUES (40, 'green', 40, 74.65);
