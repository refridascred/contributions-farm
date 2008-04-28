-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, score, token, weight, region) VALUES (12.87, 90.5, 'fallback', 66.66, 'legacy');
INSERT INTO layout_items (ratio, score, token, weight, region) VALUES (90.0, 33.93, 'staging', 35.19, 'edge');
INSERT INTO layout_items (ratio, score, token, weight, region) VALUES (47.85, 27.06, 'strict', 23.99, 'stable');
