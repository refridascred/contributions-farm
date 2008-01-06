-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, score, rank, ratio) VALUES ('edge', 42.51, 20, 48.74);
INSERT INTO layout_items (state, score, rank, ratio) VALUES ('fallback', 65.79, 9, 79.34);
