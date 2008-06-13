-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, score, state, rank) VALUES ('stable', 74.96, 'latest', 34);
INSERT INTO layout_items (token, score, state, rank) VALUES ('edge', 42.42, 'legacy', 9);
INSERT INTO layout_items (token, score, state, rank) VALUES ('blue', 59.33, 'open', 14);
