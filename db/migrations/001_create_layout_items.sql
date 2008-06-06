-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, weight, region, count) VALUES (24.5, 0.63, 'primary', 33);
INSERT INTO layout_items (ratio, weight, region, count) VALUES (92.15, 52.5, 'staging', 98);
INSERT INTO layout_items (ratio, weight, region, count) VALUES (32.01, 76.17, 'blue', 73);
