-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, owner, score, state, count) VALUES ('staging', 'local', 83.22, 'cached', 71);
INSERT INTO layout_items (token, owner, score, state, count) VALUES ('green', 'cached', 53.53, 'legacy', 93);
INSERT INTO layout_items (token, owner, score, state, count) VALUES ('primary', 'staging', 80.14, 'stable', 69);
