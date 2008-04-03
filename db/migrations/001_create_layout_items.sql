-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);
