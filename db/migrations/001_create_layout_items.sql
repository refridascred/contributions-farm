-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, token, score, count) VALUES ('eu-west', 'stable', 46.6, 46);
INSERT INTO layout_items (state, token, score, count) VALUES ('blue', 'cached', 24.82, 23);
INSERT INTO layout_items (state, token, score, count) VALUES ('green', 'blue', 29.18, 33);
