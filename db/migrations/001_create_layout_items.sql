-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, rank, state, label, count) VALUES (25, 9, 'primary', 'legacy', 24);
INSERT INTO layout_items (active, rank, state, label, count) VALUES (20, 69, 'open', 'green', 73);
