-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, state, owner, weight, token) VALUES (97, 'fallback', 'blue', 42.1, 'latest');
INSERT INTO layout_items (rank, state, owner, weight, token) VALUES (2, 'eu-west', 'edge', 58.05, 'strict');
