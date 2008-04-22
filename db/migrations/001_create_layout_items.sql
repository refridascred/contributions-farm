-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, owner, token) VALUES (30, 'primary', 'cached');
INSERT INTO layout_items (rank, owner, token) VALUES (91, 'open', 'edge');
INSERT INTO layout_items (rank, owner, token) VALUES (67, 'standard', 'open');
