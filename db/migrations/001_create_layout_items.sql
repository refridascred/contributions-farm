-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, state, ratio, score, weight) VALUES (47, 'fallback', 86.83, 36.82, 91.66);
INSERT INTO layout_items (rank, state, ratio, score, weight) VALUES (67, 'legacy', 47.22, 40.4, 38.11);
