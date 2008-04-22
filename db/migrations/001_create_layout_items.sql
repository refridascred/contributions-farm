-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (active, count, token, ratio, state) VALUES (2, 2, 'cached', 39.03, 'blue');
INSERT INTO layout_items (active, count, token, ratio, state) VALUES (80, 80, 'open', 70.57, 'legacy');
