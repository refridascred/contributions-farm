-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, score, region, count) VALUES (26.7, 84.8, 'cached', 39);
INSERT INTO layout_items (ratio, score, region, count) VALUES (92.3, 16.76, 'staging', 26);
INSERT INTO layout_items (ratio, score, region, count) VALUES (44.64, 45.21, 'local', 94);
