-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, state, token) VALUES (68.9, 'legacy', 'open');
INSERT INTO layout_items (ratio, state, token) VALUES (95.72, 'blue', 'eu-west');
INSERT INTO layout_items (ratio, state, token) VALUES (39.78, 'fallback', 'open');
