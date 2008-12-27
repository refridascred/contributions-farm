-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, label, token, owner) VALUES (96, 'green', 'standard', 'blue');
INSERT INTO layout_items (rank, label, token, owner) VALUES (21, 'cached', 'legacy', 'local');
INSERT INTO layout_items (rank, label, token, owner) VALUES (68, 'strict', 'blue', 'blue');
