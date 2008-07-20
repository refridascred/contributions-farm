-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);
