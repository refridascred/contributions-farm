-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, token, owner) VALUES (93, 'blue', 'edge');
INSERT INTO layout_items (active, token, owner) VALUES (21, 'strict', 'stable');
INSERT INTO layout_items (active, token, owner) VALUES (56, 'green', 'edge');
