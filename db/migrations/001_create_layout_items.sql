-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, score, state, active, weight) VALUES (79, 31.8, 'primary', 32, 35.18);
INSERT INTO layout_items (rank, score, state, active, weight) VALUES (34, 1.74, 'strict', 85, 91.56);
