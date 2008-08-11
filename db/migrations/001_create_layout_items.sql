-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, region, rank, level) VALUES (48.24, 'cached', 13, 93);
INSERT INTO layout_items (ratio, region, rank, level) VALUES (89.97, 'cached', 57, 31);
INSERT INTO layout_items (ratio, region, rank, level) VALUES (39.43, 'cached', 77, 36);
