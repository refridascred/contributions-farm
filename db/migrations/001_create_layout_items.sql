-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, state, count, score) VALUES ('latest', 'green', 61, 10.52);
INSERT INTO layout_items (token, state, count, score) VALUES ('fallback', 'green', 87, 20.44);
INSERT INTO layout_items (token, state, count, score) VALUES ('cached', 'legacy', 91, 14.78);
