-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, region, weight, level) VALUES (85.94, 'stable', 15.15, 18);
