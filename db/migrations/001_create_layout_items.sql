-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    ratio REAL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);
