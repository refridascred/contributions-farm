-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, rank, ratio, region) VALUES (12, 38, 90.73, 'blue');
INSERT INTO layout_items (level, rank, ratio, region) VALUES (34, 3, 77.02, 'local');
INSERT INTO layout_items (level, rank, ratio, region) VALUES (25, 28, 48.34, 'primary');
