-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, rank, region) VALUES (68.52, 81, 'strict');
INSERT INTO layout_items (ratio, rank, region) VALUES (16.53, 62, 'strict');
INSERT INTO layout_items (ratio, rank, region) VALUES (87.93, 58, 'stable');
