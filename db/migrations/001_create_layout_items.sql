-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (active, state, rank) VALUES (56, 'edge', 40);
INSERT INTO layout_items (active, state, rank) VALUES (44, 'edge', 83);
INSERT INTO layout_items (active, state, rank) VALUES (58, 'blue', 47);
