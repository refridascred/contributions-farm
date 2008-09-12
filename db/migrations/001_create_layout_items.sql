-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);
