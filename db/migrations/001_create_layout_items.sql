-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, region, score) VALUES ('standard', 42.35, 'local', 16.8);
INSERT INTO layout_items (token, ratio, region, score) VALUES ('staging', 94.15, 'green', 5.1);
