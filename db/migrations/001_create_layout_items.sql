-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, count, token, level, rank) VALUES ('local', 80, 'open', 44, 30);
INSERT INTO layout_items (state, count, token, level, rank) VALUES ('green', 20, 'open', 1, 47);
INSERT INTO layout_items (state, count, token, level, rank) VALUES ('blue', 9, 'stable', 33, 1);
