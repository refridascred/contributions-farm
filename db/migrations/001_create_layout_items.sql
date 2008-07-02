-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, region, score, label) VALUES (84.27, 'blue', 45.09, 'green');
INSERT INTO layout_items (ratio, region, score, label) VALUES (94.86, 'strict', 81.99, 'strict');
INSERT INTO layout_items (ratio, region, score, label) VALUES (72.15, 'stable', 11.77, 'legacy');
