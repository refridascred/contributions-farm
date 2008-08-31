-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, state, active, rank, score) VALUES (54.98, 'primary', 23, 30, 9.71);
INSERT INTO layout_items (weight, state, active, rank, score) VALUES (72.64, 'edge', 12, 31, 45.44);
