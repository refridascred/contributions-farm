-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);
