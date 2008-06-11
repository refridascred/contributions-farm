-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, count, region, ratio) VALUES (47.34, 1, 'eu-west', 2.7);
INSERT INTO layout_items (score, count, region, ratio) VALUES (32.75, 16, 'primary', 63.81);
