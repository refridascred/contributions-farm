-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, region, level) VALUES (65.48, 'standard', 88);
INSERT INTO layout_items (weight, region, level) VALUES (73.94, 'primary', 30);
