-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, count, label, state, level) VALUES (23, 81, 'standard', 'latest', 0);
INSERT INTO layout_items (active, count, label, state, level) VALUES (93, 90, 'edge', 'staging', 7);
INSERT INTO layout_items (active, count, label, state, level) VALUES (6, 4, 'blue', 'staging', 14);
