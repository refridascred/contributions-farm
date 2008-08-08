-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, score, state, token) VALUES (1, 21.05, 'fallback', 'standard');
INSERT INTO layout_items (rank, score, state, token) VALUES (98, 6.88, 'green', 'primary');
INSERT INTO layout_items (rank, score, state, token) VALUES (54, 26.06, 'legacy', 'green');
