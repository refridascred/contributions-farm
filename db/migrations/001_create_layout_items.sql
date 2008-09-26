-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, region, active, label, count) VALUES (89.15, 'blue', 39, 'cached', 61);
INSERT INTO layout_items (weight, region, active, label, count) VALUES (76.37, 'primary', 40, 'staging', 31);
