-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, score, active, state, token) VALUES (69, 57.34, 72, 'staging', 'local');
INSERT INTO layout_items (rank, score, active, state, token) VALUES (22, 1.48, 83, 'legacy', 'blue');
INSERT INTO layout_items (rank, score, active, state, token) VALUES (19, 0.72, 81, 'edge', 'local');
