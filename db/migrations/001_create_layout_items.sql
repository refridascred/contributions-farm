-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, score, token, count, region) VALUES (5.51, 28.46, 'edge', 54, 'stable');
INSERT INTO layout_items (weight, score, token, count, region) VALUES (67.37, 1.21, 'strict', 49, 'stable');
