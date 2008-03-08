-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (active, state, score, token, region) VALUES (21, 'staging', 88.89, 'open', 'standard');
INSERT INTO layout_items (active, state, score, token, region) VALUES (48, 'fallback', 13.9, 'local', 'local');
INSERT INTO layout_items (active, state, score, token, region) VALUES (21, 'open', 68.17, 'stable', 'cached');
