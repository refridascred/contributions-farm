-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);
