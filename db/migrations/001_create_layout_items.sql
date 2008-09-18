-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, level, count, region, label) VALUES (81.41, 63, 66, 'green', 'edge');
INSERT INTO layout_items (ratio, level, count, region, label) VALUES (0.26, 39, 51, 'strict', 'cached');
