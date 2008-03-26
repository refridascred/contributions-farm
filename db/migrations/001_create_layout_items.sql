-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, rank, token) VALUES ('local', 36, 'open');
INSERT INTO layout_items (state, rank, token) VALUES ('edge', 45, 'strict');
INSERT INTO layout_items (state, rank, token) VALUES ('standard', 50, 'blue');
