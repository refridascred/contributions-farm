-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, count, ratio, region) VALUES (6.88, 28, 85.73, 'open');
INSERT INTO layout_items (weight, count, ratio, region) VALUES (74.54, 2, 49.29, 'edge');
INSERT INTO layout_items (weight, count, ratio, region) VALUES (33.48, 2, 11.91, 'cached');
