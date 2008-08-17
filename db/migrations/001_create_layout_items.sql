-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, token, state, score, active) VALUES (3, 'fallback', 'standard', 54.56, 71);
INSERT INTO layout_items (rank, token, state, score, active) VALUES (26, 'legacy', 'staging', 68.73, 58);
INSERT INTO layout_items (rank, token, state, score, active) VALUES (91, 'staging', 'stable', 83.4, 71);
