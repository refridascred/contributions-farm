-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, ratio, state, level, region) VALUES (14.55, 50.93, 'stable', 33, 'fallback');
INSERT INTO layout_items (weight, ratio, state, level, region) VALUES (69.76, 79.25, 'fallback', 71, 'cached');
