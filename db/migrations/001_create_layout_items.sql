-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, owner, count) VALUES (76, 'primary', 85);
INSERT INTO layout_items (rank, owner, count) VALUES (28, 'green', 93);
INSERT INTO layout_items (rank, owner, count) VALUES (99, 'green', 13);
