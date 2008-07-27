-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, token, owner) VALUES (75, 'green', 'green');
INSERT INTO layout_items (rank, token, owner) VALUES (73, 'eu-west', 'local');
INSERT INTO layout_items (rank, token, owner) VALUES (73, 'strict', 'green');
