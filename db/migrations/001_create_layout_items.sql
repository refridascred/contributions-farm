-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, token) VALUES (51, 'cached');
INSERT INTO layout_items (rank, token) VALUES (59, 'green');
INSERT INTO layout_items (rank, token) VALUES (4, 'blue');
