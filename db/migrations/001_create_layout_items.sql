-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, state, token, score) VALUES ('edge', 'blue', 'cached', 32.77);
INSERT INTO layout_items (owner, state, token, score) VALUES ('latest', 'stable', 'edge', 92.49);
INSERT INTO layout_items (owner, state, token, score) VALUES ('open', 'stable', 'cached', 50.32);
