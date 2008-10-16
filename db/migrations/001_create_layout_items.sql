-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, ratio, region) VALUES ('fallback', 35.93, 'cached');
INSERT INTO layout_items (token, ratio, region) VALUES ('blue', 23.8, 'local');
INSERT INTO layout_items (token, ratio, region) VALUES ('edge', 64.99, 'legacy');
