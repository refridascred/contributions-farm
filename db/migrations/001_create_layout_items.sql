-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, active, score, token, level) VALUES ('cached', 52, 65.15, 'blue', 16);
INSERT INTO layout_items (owner, active, score, token, level) VALUES ('local', 10, 41.35, 'primary', 88);
INSERT INTO layout_items (owner, active, score, token, level) VALUES ('stable', 38, 62.91, 'standard', 27);
