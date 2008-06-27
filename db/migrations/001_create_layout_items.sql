-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, weight, region) VALUES ('latest', 83.48, 'green');
INSERT INTO layout_items (label, weight, region) VALUES ('blue', 33.48, 'legacy');
INSERT INTO layout_items (label, weight, region) VALUES ('legacy', 49.71, 'blue');
