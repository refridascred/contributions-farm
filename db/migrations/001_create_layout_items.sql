-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);
