-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, region, count, weight) VALUES (98.36, 'stable', 98, 9.63);
INSERT INTO layout_items (ratio, region, count, weight) VALUES (9.54, 'legacy', 54, 12.53);
INSERT INTO layout_items (ratio, region, count, weight) VALUES (28.2, 'standard', 74, 5.27);
