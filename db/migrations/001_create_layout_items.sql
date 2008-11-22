-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, level, score, state) VALUES (25, 40, 94.08, 'standard');
INSERT INTO layout_items (rank, level, score, state) VALUES (53, 50, 38.31, 'fallback');
INSERT INTO layout_items (rank, level, score, state) VALUES (4, 53, 4.5, 'stable');
