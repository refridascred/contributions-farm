-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, ratio, weight, region) VALUES ('edge', 40.48, 7.44, 'strict');
INSERT INTO layout_items (token, ratio, weight, region) VALUES ('fallback', 13.21, 85.85, 'edge');
