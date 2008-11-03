-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, token, state, active) VALUES (16, 'green', 'edge', 4);
INSERT INTO layout_items (rank, token, state, active) VALUES (11, 'cached', 'eu-west', 69);
INSERT INTO layout_items (rank, token, state, active) VALUES (53, 'edge', 'edge', 57);
