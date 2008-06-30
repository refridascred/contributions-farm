-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);
