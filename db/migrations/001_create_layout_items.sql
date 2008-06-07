-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (count, owner) VALUES (8, 'primary');
INSERT INTO layout_items (count, owner) VALUES (45, 'strict');
INSERT INTO layout_items (count, owner) VALUES (4, 'edge');
