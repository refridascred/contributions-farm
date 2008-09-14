-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, state, token) VALUES (56.25, 'fallback', 'blue');
INSERT INTO layout_items (ratio, state, token) VALUES (1.79, 'local', 'cached');
INSERT INTO layout_items (ratio, state, token) VALUES (17.42, 'latest', 'green');
