-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, ratio, region) VALUES (40, 95.34, 'strict');
INSERT INTO layout_items (rank, ratio, region) VALUES (31, 95.32, 'blue');
