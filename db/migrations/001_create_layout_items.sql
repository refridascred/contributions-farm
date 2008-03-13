-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, state, score, weight) VALUES (53, 'blue', 92.31, 8.76);
INSERT INTO layout_items (rank, state, score, weight) VALUES (11, 'open', 22.63, 25.82);
INSERT INTO layout_items (rank, state, score, weight) VALUES (37, 'staging', 47.73, 85.7);
