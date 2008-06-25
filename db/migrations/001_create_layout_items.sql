-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, token) VALUES (69, 'fallback');
INSERT INTO layout_items (level, token) VALUES (8, 'standard');
INSERT INTO layout_items (level, token) VALUES (18, 'staging');
