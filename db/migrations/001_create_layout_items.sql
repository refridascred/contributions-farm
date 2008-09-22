-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, token, state, score, rank) VALUES (49, 'stable', 'standard', 23.81, 89);
INSERT INTO layout_items (count, token, state, score, rank) VALUES (60, 'fallback', 'eu-west', 0.76, 67);
INSERT INTO layout_items (count, token, state, score, rank) VALUES (26, 'green', 'cached', 75.2, 39);
