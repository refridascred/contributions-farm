-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);
