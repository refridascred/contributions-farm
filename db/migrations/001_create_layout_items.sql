-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, owner, token, state) VALUES (50, 'eu-west', 'edge', 'local');
INSERT INTO layout_items (rank, owner, token, state) VALUES (65, 'green', 'latest', 'strict');
INSERT INTO layout_items (rank, owner, token, state) VALUES (29, 'latest', 'standard', 'local');
