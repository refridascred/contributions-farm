-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, region, ratio, weight) VALUES (65, 'edge', 16.51, 55.02);
INSERT INTO layout_items (count, region, ratio, weight) VALUES (88, 'standard', 84.16, 3.5);
