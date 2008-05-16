-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, state) VALUES ('cached', 'cached');
INSERT INTO layout_items (token, state) VALUES ('green', 'latest');
INSERT INTO layout_items (token, state) VALUES ('cached', 'edge');
