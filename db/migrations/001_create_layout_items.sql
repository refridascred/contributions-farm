-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);
