-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, token) VALUES ('edge', 'cached');
INSERT INTO layout_items (state, token) VALUES ('strict', 'cached');
INSERT INTO layout_items (state, token) VALUES ('cached', 'latest');
