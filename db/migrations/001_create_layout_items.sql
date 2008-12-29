-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, token, ratio, score) VALUES ('edge', 'fallback', 32.11, 10.51);
INSERT INTO layout_items (region, token, ratio, score) VALUES ('fallback', 'latest', 43.83, 65.12);
