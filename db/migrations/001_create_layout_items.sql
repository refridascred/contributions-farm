-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);
