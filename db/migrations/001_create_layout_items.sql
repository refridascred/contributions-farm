-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, ratio, level, score, token) VALUES (3, 14.91, 6, 22.19, 'eu-west');
INSERT INTO layout_items (active, ratio, level, score, token) VALUES (56, 31.13, 19, 67.05, 'latest');
