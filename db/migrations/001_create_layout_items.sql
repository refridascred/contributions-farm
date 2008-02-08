-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, token) VALUES ('stable', 'standard');
INSERT INTO layout_items (owner, token) VALUES ('staging', 'primary');
INSERT INTO layout_items (owner, token) VALUES ('blue', 'cached');
