-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (active, state, level) VALUES (1, 'edge', 14);
INSERT INTO layout_items (active, state, level) VALUES (67, 'standard', 81);
INSERT INTO layout_items (active, state, level) VALUES (34, 'open', 60);
