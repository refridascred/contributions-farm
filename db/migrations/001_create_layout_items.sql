-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, token, score, rank, label) VALUES ('open', 'fallback', 34.22, 27, 'legacy');
INSERT INTO layout_items (state, token, score, rank, label) VALUES ('fallback', 'staging', 42.1, 85, 'legacy');
INSERT INTO layout_items (state, token, score, rank, label) VALUES ('open', 'legacy', 3.58, 50, 'edge');
