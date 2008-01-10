-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, count, label) VALUES (65, 25, 'stable');
