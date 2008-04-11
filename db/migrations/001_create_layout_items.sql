-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, score, active, count, token) VALUES (62, 27.11, 44, 81, 'blue');
INSERT INTO layout_items (level, score, active, count, token) VALUES (0, 45.9, 89, 61, 'standard');
INSERT INTO layout_items (level, score, active, count, token) VALUES (31, 4.94, 56, 58, 'open');
