-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (count, token, ratio, region) VALUES (37, 'stable', 60.74, 'edge');
INSERT INTO layout_items (count, token, ratio, region) VALUES (22, 'legacy', 44.86, 'standard');
