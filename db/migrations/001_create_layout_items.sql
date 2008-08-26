-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, region, weight, token) VALUES (67.05, 'local', 25.62, 'green');
INSERT INTO layout_items (ratio, region, weight, token) VALUES (77.84, 'stable', 82.68, 'strict');
