-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, active, level, token) VALUES (92.63, 48, 41, 'local');
INSERT INTO layout_items (score, active, level, token) VALUES (25.72, 44, 14, 'local');
