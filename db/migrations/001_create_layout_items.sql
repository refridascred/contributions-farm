-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, region, count, weight) VALUES (59.01, 'blue', 14, 88.92);
INSERT INTO layout_items (ratio, region, count, weight) VALUES (49.43, 'staging', 21, 52.0);
INSERT INTO layout_items (ratio, region, count, weight) VALUES (5.36, 'stable', 48, 77.98);
