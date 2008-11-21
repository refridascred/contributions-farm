-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, level, region, state) VALUES (73.82, 3, 'green', 'edge');
INSERT INTO layout_items (ratio, level, region, state) VALUES (98.33, 15, 'stable', 'cached');
