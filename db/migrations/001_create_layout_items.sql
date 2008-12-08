-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, count, token) VALUES (27, 33, 'open');
INSERT INTO layout_items (rank, count, token) VALUES (20, 43, 'green');
INSERT INTO layout_items (rank, count, token) VALUES (23, 23, 'latest');
