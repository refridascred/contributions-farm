-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, score, token, state, ratio) VALUES (72, 63.59, 'legacy', 'green', 44.93);
INSERT INTO layout_items (rank, score, token, state, ratio) VALUES (33, 52.17, 'latest', 'primary', 55.57);
INSERT INTO layout_items (rank, score, token, state, ratio) VALUES (36, 93.56, 'stable', 'cached', 43.0);
