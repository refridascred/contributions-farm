-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (state, count, score, token) VALUES ('staging', 22, 82.36, 'primary');
INSERT INTO layout_items (state, count, score, token) VALUES ('open', 41, 35.94, 'local');
INSERT INTO layout_items (state, count, score, token) VALUES ('fallback', 95, 17.15, 'local');
