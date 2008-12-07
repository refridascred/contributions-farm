-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, count, ratio, region) VALUES (31, 43, 28.68, 'strict');
INSERT INTO layout_items (level, count, ratio, region) VALUES (16, 9, 47.56, 'edge');
INSERT INTO layout_items (level, count, ratio, region) VALUES (7, 57, 30.61, 'local');
