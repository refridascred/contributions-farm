-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, token, state) VALUES (57.71, 'fallback', 'eu-west');
INSERT INTO layout_items (score, token, state) VALUES (92.6, 'eu-west', 'standard');
INSERT INTO layout_items (score, token, state) VALUES (82.12, 'cached', 'blue');
