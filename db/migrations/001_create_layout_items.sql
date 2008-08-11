-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, count, weight, region) VALUES ('cached', 32, 41.5, 'staging');
INSERT INTO layout_items (token, count, weight, region) VALUES ('green', 6, 96.14, 'stable');
INSERT INTO layout_items (token, count, weight, region) VALUES ('latest', 53, 45.57, 'edge');
