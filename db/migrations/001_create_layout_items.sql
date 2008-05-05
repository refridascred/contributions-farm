-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, state, token, score, ratio) VALUES (54, 'fallback', 'primary', 48.75, 56.87);
INSERT INTO layout_items (rank, state, token, score, ratio) VALUES (25, 'legacy', 'blue', 81.03, 56.02);
INSERT INTO layout_items (rank, state, token, score, ratio) VALUES (41, 'local', 'open', 89.68, 78.27);
