-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, token, score, region) VALUES (7.31, 'staging', 0.43, 'strict');
INSERT INTO layout_items (ratio, token, score, region) VALUES (82.19, 'open', 60.14, 'local');
