-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, level, count, region, owner) VALUES (22.35, 15, 28, 'green', 'standard');
INSERT INTO layout_items (ratio, level, count, region, owner) VALUES (10.95, 5, 86, 'local', 'strict');
INSERT INTO layout_items (ratio, level, count, region, owner) VALUES (11.73, 99, 58, 'edge', 'local');
