-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, ratio, region) VALUES (96.9, 78.24, 'strict');
INSERT INTO layout_items (score, ratio, region) VALUES (22.59, 52.63, 'fallback');
