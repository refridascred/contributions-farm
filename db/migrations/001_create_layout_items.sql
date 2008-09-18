-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, token, label) VALUES (17, 'primary', 'strict');
INSERT INTO layout_items (rank, token, label) VALUES (45, 'local', 'legacy');
INSERT INTO layout_items (rank, token, label) VALUES (13, 'stable', 'local');
