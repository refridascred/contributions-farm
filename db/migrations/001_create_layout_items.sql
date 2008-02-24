-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, ratio, token, region) VALUES (82, 65.88, 'eu-west', 'legacy');
INSERT INTO layout_items (count, ratio, token, region) VALUES (86, 97.24, 'latest', 'edge');
