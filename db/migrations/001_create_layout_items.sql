-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, count, token) VALUES ('primary', 75, 'local');
INSERT INTO layout_items (owner, count, token) VALUES ('primary', 47, 'edge');
INSERT INTO layout_items (owner, count, token) VALUES ('legacy', 10, 'primary');
