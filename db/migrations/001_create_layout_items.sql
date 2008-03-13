-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, count, region) VALUES (72.41, 78, 'stable');
INSERT INTO layout_items (weight, count, region) VALUES (14.18, 64, 'strict');
INSERT INTO layout_items (weight, count, region) VALUES (23.61, 74, 'legacy');
