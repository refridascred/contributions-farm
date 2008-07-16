-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, weight, level, ratio, score) VALUES ('edge', 0.05, 84, 29.0, 61.26);
INSERT INTO layout_items (region, weight, level, ratio, score) VALUES ('stable', 59.87, 52, 34.24, 63.33);
