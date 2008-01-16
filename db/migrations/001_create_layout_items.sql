-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (score, count, ratio, region) VALUES (44.09, 27, 97.16, 'blue');
INSERT INTO layout_items (score, count, ratio, region) VALUES (71.18, 77, 16.26, 'eu-west');
INSERT INTO layout_items (score, count, ratio, region) VALUES (94.26, 46, 46.56, 'local');
