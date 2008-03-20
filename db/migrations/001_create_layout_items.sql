-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, level, count, region) VALUES (3, 95, 91, 'staging');
INSERT INTO layout_items (rank, level, count, region) VALUES (34, 14, 40, 'local');
INSERT INTO layout_items (rank, level, count, region) VALUES (49, 18, 26, 'primary');
