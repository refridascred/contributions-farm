-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);
