-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, region, level, owner) VALUES (86.08, 'staging', 20, 'latest');
INSERT INTO layout_items (ratio, region, level, owner) VALUES (76.23, 'strict', 43, 'stable');
INSERT INTO layout_items (ratio, region, level, owner) VALUES (38.25, 'latest', 19, 'local');
