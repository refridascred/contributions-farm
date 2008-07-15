-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, weight, level, ratio, region) VALUES ('legacy', 52.98, 56, 25.95, 'strict');
INSERT INTO layout_items (state, weight, level, ratio, region) VALUES ('fallback', 55.32, 41, 7.0, 'blue');
