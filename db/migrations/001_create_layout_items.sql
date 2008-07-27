-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, region, score, ratio, level) VALUES (97, 'primary', 41.82, 52.08, 33);
INSERT INTO layout_items (count, region, score, ratio, level) VALUES (20, 'blue', 38.6, 37.01, 74);
