-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (active, score, token, rank, ratio) VALUES (99, 52.36, 'cached', 93, 17.92);
INSERT INTO layout_items (active, score, token, rank, ratio) VALUES (41, 59.8, 'edge', 23, 94.24);
INSERT INTO layout_items (active, score, token, rank, ratio) VALUES (54, 36.87, 'stable', 27, 73.65);
