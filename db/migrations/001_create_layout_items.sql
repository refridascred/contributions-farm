-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, count, score, label, state) VALUES ('stable', 94, 64.79, 'latest', 'strict');
INSERT INTO layout_items (token, count, score, label, state) VALUES ('open', 54, 22.28, 'latest', 'open');
INSERT INTO layout_items (token, count, score, label, state) VALUES ('standard', 30, 43.85, 'primary', 'blue');
