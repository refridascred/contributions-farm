-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, active, region, weight, label) VALUES (41.86, 4, 'green', 28.86, 'green');
INSERT INTO layout_items (ratio, active, region, weight, label) VALUES (4.54, 19, 'primary', 83.34, 'green');
