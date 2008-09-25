-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (active, rank, owner, token) VALUES (71, 17, 'local', 'eu-west');
INSERT INTO layout_items (active, rank, owner, token) VALUES (16, 74, 'cached', 'fallback');
