-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);
