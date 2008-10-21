-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, level, active, region) VALUES (38.27, 17, 49, 'staging');
INSERT INTO layout_items (ratio, level, active, region) VALUES (85.81, 21, 18, 'blue');
