-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (score, active, rank, state, token) VALUES (8.17, 73, 27, 'edge', 'green');
INSERT INTO layout_items (score, active, rank, state, token) VALUES (51.99, 40, 1, 'stable', 'stable');
