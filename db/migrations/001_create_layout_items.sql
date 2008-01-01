-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, score, ratio, token) VALUES (41.31, 35.51, 61.3, 'latest');
