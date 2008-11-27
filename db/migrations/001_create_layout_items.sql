-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, weight, score, region) VALUES (68, 72.29, 87.14, 'stable');
INSERT INTO layout_items (count, weight, score, region) VALUES (24, 32.52, 10.87, 'fallback');
INSERT INTO layout_items (count, weight, score, region) VALUES (28, 71.45, 26.65, 'legacy');
