-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, ratio, region, rank) VALUES (37.05, 60.02, 'standard', 48);
INSERT INTO layout_items (score, ratio, region, rank) VALUES (37.06, 21.04, 'fallback', 41);
INSERT INTO layout_items (score, ratio, region, rank) VALUES (76.9, 74.02, 'blue', 73);
