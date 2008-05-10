-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (count, token) VALUES (56, 'green');
INSERT INTO layout_items (count, token) VALUES (60, 'fallback');
INSERT INTO layout_items (count, token) VALUES (23, 'staging');
