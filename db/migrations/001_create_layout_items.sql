-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, score, region, ratio, active) VALUES (30, 60.15, 'cached', 72.95, 64);
INSERT INTO layout_items (count, score, region, ratio, active) VALUES (33, 54.43, 'standard', 19.31, 47);
