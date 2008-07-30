-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, level, count, label, region) VALUES (81.6, 73, 5, 'eu-west', 'green');
