-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (score, count, region, ratio) VALUES (64.16, 57, 'blue', 41.81);
INSERT INTO layout_items (score, count, region, ratio) VALUES (7.05, 52, 'standard', 18.28);
INSERT INTO layout_items (score, count, region, ratio) VALUES (89.5, 12, 'blue', 82.23);
