-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (count, ratio, score, token) VALUES (42, 60.68, 74.61, 'open');
INSERT INTO layout_items (count, ratio, score, token) VALUES (34, 78.63, 8.25, 'blue');
INSERT INTO layout_items (count, ratio, score, token) VALUES (56, 49.27, 0.01, 'local');
