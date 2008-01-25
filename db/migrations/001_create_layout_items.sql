-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, region, ratio) VALUES ('latest', 'fallback', 11.48);
INSERT INTO layout_items (token, region, ratio) VALUES ('edge', 'open', 98.38);
INSERT INTO layout_items (token, region, ratio) VALUES ('local', 'stable', 41.93);
