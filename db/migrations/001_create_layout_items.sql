-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, region, weight, active) VALUES (13.49, 'primary', 92.71, 94);
INSERT INTO layout_items (ratio, region, weight, active) VALUES (51.58, 'cached', 8.4, 4);
