-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, token, state, rank, score) VALUES (31.54, 'standard', 'blue', 86, 56.18);
INSERT INTO layout_items (ratio, token, state, rank, score) VALUES (42.32, 'fallback', 'stable', 42, 78.97);
