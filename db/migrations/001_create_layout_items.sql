-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, count, region) VALUES (38.3, 50, 'latest');
INSERT INTO layout_items (ratio, count, region) VALUES (40.17, 75, 'blue');
INSERT INTO layout_items (ratio, count, region) VALUES (29.21, 67, 'legacy');
