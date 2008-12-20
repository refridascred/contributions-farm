-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, ratio, region) VALUES (65.88, 39.17, 'blue');
INSERT INTO layout_items (score, ratio, region) VALUES (93.31, 46.21, 'staging');
INSERT INTO layout_items (score, ratio, region) VALUES (48.89, 82.72, 'primary');
