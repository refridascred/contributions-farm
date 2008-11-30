-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, weight, region, owner) VALUES (47.59, 23.82, 'legacy', 'legacy');
INSERT INTO layout_items (ratio, weight, region, owner) VALUES (11.67, 92.7, 'edge', 'green');
INSERT INTO layout_items (ratio, weight, region, owner) VALUES (47.06, 85.83, 'green', 'latest');
