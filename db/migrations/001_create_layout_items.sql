-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, score, region, token) VALUES (20.94, 82.69, 'latest', 'latest');
INSERT INTO layout_items (weight, score, region, token) VALUES (85.72, 38.53, 'eu-west', 'edge');
