-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, score, ratio, token) VALUES (41, 10.2, 56.55, 'latest');
INSERT INTO layout_items (rank, score, ratio, token) VALUES (87, 83.63, 48.74, 'stable');
