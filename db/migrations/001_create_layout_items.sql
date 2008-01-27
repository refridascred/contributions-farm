-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);
