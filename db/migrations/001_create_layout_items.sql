-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, rank, level, region) VALUES (34.32, 46, 31, 'stable');
INSERT INTO layout_items (ratio, rank, level, region) VALUES (36.53, 63, 27, 'cached');
