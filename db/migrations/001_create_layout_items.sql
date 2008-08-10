-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (count, owner) VALUES (56, 'primary');
INSERT INTO layout_items (count, owner) VALUES (15, 'green');
INSERT INTO layout_items (count, owner) VALUES (10, 'local');
