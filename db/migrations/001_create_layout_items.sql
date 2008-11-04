-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);
