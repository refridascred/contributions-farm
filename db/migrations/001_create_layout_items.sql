-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);
