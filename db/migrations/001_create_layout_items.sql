-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, count, rank, score, token) VALUES (53.97, 31, 8, 81.49, 'stable');
INSERT INTO layout_items (weight, count, rank, score, token) VALUES (2.52, 6, 22, 27.96, 'green');
