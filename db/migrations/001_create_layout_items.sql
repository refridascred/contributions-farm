-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, region, token, score) VALUES (15.67, 'fallback', 'staging', 55.26);
INSERT INTO layout_items (ratio, region, token, score) VALUES (75.47, 'staging', 'local', 88.16);
INSERT INTO layout_items (ratio, region, token, score) VALUES (92.73, 'staging', 'staging', 98.25);
