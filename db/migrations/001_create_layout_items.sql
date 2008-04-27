-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);
