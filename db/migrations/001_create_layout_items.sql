-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, token, state, rank, owner) VALUES (11.91, 'fallback', 'blue', 1, 'eu-west');
INSERT INTO layout_items (score, token, state, rank, owner) VALUES (58.86, 'standard', 'blue', 41, 'fallback');
