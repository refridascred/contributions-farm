-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);
