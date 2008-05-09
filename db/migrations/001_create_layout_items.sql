-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);
