-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, weight, region) VALUES (35, 50.86, 'strict');
INSERT INTO layout_items (level, weight, region) VALUES (58, 37.39, 'eu-west');
