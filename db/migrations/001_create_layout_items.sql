-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, label, token) VALUES (34, 'edge', 'legacy');
INSERT INTO layout_items (rank, label, token) VALUES (21, 'cached', 'latest');
