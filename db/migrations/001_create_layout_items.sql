-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);
