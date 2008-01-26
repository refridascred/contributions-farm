-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, ratio, region) VALUES (1.86, 12.5, 'staging');
INSERT INTO layout_items (weight, ratio, region) VALUES (51.1, 63.59, 'green');
