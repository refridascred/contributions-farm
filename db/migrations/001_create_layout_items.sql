-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, region, ratio, score, level) VALUES (76, 'fallback', 29.14, 55.54, 91);
INSERT INTO layout_items (rank, region, ratio, score, level) VALUES (31, 'legacy', 85.48, 36.89, 19);
