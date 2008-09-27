-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);
