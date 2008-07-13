-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);
