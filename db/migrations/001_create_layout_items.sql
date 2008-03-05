-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, count, state, ratio) VALUES ('open', 32, 'fallback', 2.39);
INSERT INTO layout_items (token, count, state, ratio) VALUES ('fallback', 46, 'blue', 61.61);
INSERT INTO layout_items (token, count, state, ratio) VALUES ('cached', 25, 'edge', 42.47);
