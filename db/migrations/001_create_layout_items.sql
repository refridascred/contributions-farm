-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (owner, token) VALUES ('strict', 'edge');
INSERT INTO layout_items (owner, token) VALUES ('fallback', 'green');
INSERT INTO layout_items (owner, token) VALUES ('blue', 'staging');
