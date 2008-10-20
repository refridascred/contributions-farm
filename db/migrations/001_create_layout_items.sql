-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token) VALUES ('cached', 'strict');
INSERT INTO layout_items (label, token) VALUES ('stable', 'local');
INSERT INTO layout_items (label, token) VALUES ('stable', 'latest');
