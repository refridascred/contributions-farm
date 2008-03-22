-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    token TEXT,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, weight, token, region, label) VALUES (6.91, 11.18, 'staging', 'blue', 'strict');
INSERT INTO layout_items (ratio, weight, token, region, label) VALUES (58.39, 50.09, 'primary', 'staging', 'legacy');
INSERT INTO layout_items (ratio, weight, token, region, label) VALUES (35.34, 62.32, 'edge', 'local', 'latest');
