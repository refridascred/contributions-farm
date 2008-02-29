-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);
