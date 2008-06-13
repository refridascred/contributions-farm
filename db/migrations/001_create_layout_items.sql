-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, label, rank) VALUES (3, 'cached', 5);
INSERT INTO layout_items (active, label, rank) VALUES (67, 'strict', 79);
