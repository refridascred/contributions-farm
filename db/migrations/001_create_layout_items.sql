-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, region, score, weight, ratio) VALUES (88, 'staging', 28.19, 41.24, 59.09);
INSERT INTO layout_items (level, region, score, weight, ratio) VALUES (18, 'stable', 49.08, 4.55, 9.29);
INSERT INTO layout_items (level, region, score, weight, ratio) VALUES (64, 'latest', 42.4, 90.0, 84.16);
