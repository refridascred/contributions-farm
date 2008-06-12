-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);
