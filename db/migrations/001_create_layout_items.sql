-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, ratio, token) VALUES (86.74, 44.63, 'strict');
INSERT INTO layout_items (score, ratio, token) VALUES (82.36, 44.52, 'eu-west');
INSERT INTO layout_items (score, ratio, token) VALUES (41.41, 30.7, 'legacy');
