-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, ratio, region, owner) VALUES ('green', 24.27, 'strict', 'cached');
INSERT INTO layout_items (token, ratio, region, owner) VALUES ('edge', 70.49, 'fallback', 'edge');
INSERT INTO layout_items (token, ratio, region, owner) VALUES ('stable', 94.87, 'staging', 'cached');
