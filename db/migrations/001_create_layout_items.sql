-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, score, region) VALUES (32.56, 67.44, 'cached');
INSERT INTO layout_items (ratio, score, region) VALUES (7.32, 57.26, 'fallback');
INSERT INTO layout_items (ratio, score, region) VALUES (37.11, 81.12, 'latest');
