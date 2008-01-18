-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, region, label) VALUES ('fallback', 70.89, 'strict', 'latest');
INSERT INTO layout_items (token, ratio, region, label) VALUES ('stable', 72.24, 'open', 'primary');
