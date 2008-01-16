-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, ratio, count, rank, token) VALUES (36.26, 15.82, 93, 21, 'fallback');
INSERT INTO layout_items (score, ratio, count, rank, token) VALUES (53.71, 3.28, 19, 56, 'strict');
INSERT INTO layout_items (score, ratio, count, rank, token) VALUES (74.94, 46.7, 25, 6, 'green');
