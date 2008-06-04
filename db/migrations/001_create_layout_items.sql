-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, score, state, level, ratio) VALUES ('stable', 93.29, 'fallback', 25, 78.79);
INSERT INTO layout_items (token, score, state, level, ratio) VALUES ('local', 32.92, 'green', 6, 3.81);
INSERT INTO layout_items (token, score, state, level, ratio) VALUES ('green', 98.58, 'blue', 69, 21.88);
