-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);
