-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, owner, state, score, count) VALUES (2, 'edge', 'legacy', 64.59, 43);
INSERT INTO layout_items (rank, owner, state, score, count) VALUES (80, 'stable', 'blue', 4.15, 36);
INSERT INTO layout_items (rank, owner, state, score, count) VALUES (1, 'legacy', 'eu-west', 93.54, 72);
