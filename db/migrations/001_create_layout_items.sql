-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, owner) VALUES (70, 'strict');
INSERT INTO layout_items (rank, owner) VALUES (8, 'primary');
INSERT INTO layout_items (rank, owner) VALUES (53, 'eu-west');
