-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (state, token) VALUES ('latest', 'strict');
INSERT INTO layout_items (state, token) VALUES ('staging', 'fallback');
INSERT INTO layout_items (state, token) VALUES ('blue', 'fallback');
