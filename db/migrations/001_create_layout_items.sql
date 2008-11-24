-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, ratio, level, region, state) VALUES (69.96, 78.61, 26, 'legacy', 'latest');
INSERT INTO layout_items (weight, ratio, level, region, state) VALUES (52.29, 77.49, 54, 'blue', 'local');
INSERT INTO layout_items (weight, ratio, level, region, state) VALUES (5.95, 5.94, 46, 'latest', 'open');
