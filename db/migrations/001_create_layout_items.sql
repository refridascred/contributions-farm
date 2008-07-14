-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, token) VALUES ('cached', 'strict');
INSERT INTO layout_items (label, token) VALUES ('cached', 'primary');
INSERT INTO layout_items (label, token) VALUES ('stable', 'fallback');
