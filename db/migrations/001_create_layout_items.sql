-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, score, level, state) VALUES ('blue', 77.16, 32, 'green');
INSERT INTO layout_items (token, score, level, state) VALUES ('stable', 25.61, 90, 'fallback');
INSERT INTO layout_items (token, score, level, state) VALUES ('eu-west', 47.52, 24, 'local');
