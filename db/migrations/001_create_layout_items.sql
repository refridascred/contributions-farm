-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, region, level, ratio, weight) VALUES (95.91, 'strict', 39, 11.92, 20.47);
INSERT INTO layout_items (score, region, level, ratio, weight) VALUES (36.29, 'latest', 73, 46.56, 43.34);
INSERT INTO layout_items (score, region, level, ratio, weight) VALUES (64.8, 'standard', 31, 47.61, 66.21);
