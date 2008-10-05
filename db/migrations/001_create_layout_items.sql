-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, score, rank, region, state) VALUES (69, 60.71, 69, 'latest', 'fallback');
INSERT INTO layout_items (count, score, rank, region, state) VALUES (99, 76.6, 40, 'cached', 'stable');
INSERT INTO layout_items (count, score, rank, region, state) VALUES (57, 52.16, 61, 'latest', 'fallback');
