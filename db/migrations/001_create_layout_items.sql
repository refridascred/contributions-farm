-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, label, score, state, token) VALUES (32.59, 'local', 54.49, 'legacy', 'cached');
INSERT INTO layout_items (ratio, label, score, state, token) VALUES (16.06, 'eu-west', 82.39, 'green', 'blue');
