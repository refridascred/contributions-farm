-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (count, token, state, score) VALUES (73, 'eu-west', 'stable', 42.7);
INSERT INTO layout_items (count, token, state, score) VALUES (76, 'eu-west', 'legacy', 83.95);
INSERT INTO layout_items (count, token, state, score) VALUES (41, 'open', 'fallback', 10.07);
