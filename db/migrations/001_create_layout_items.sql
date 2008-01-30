-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, ratio, region) VALUES (24.3, 46.84, 'stable');
INSERT INTO layout_items (score, ratio, region) VALUES (45.35, 97.31, 'eu-west');
