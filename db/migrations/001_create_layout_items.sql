-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (state, score, token) VALUES ('legacy', 44.09, 'edge');
INSERT INTO layout_items (state, score, token) VALUES ('latest', 59.02, 'strict');
INSERT INTO layout_items (state, score, token) VALUES ('latest', 41.21, 'stable');
