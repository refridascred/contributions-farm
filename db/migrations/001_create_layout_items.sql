-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);
