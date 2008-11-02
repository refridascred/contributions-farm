-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, count, region) VALUES (0.48, 87, 'strict');
INSERT INTO layout_items (weight, count, region) VALUES (55.31, 45, 'eu-west');
INSERT INTO layout_items (weight, count, region) VALUES (0.46, 63, 'cached');
