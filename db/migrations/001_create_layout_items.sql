-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, ratio, weight, region) VALUES (19, 79.79, 75.22, 'legacy');
INSERT INTO layout_items (count, ratio, weight, region) VALUES (86, 64.43, 44.03, 'primary');
INSERT INTO layout_items (count, ratio, weight, region) VALUES (38, 25.11, 3.23, 'legacy');
