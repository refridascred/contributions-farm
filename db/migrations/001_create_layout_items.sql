-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (region, state, token) VALUES ('local', 'cached', 'open');
INSERT INTO layout_items (region, state, token) VALUES ('eu-west', 'fallback', 'strict');
INSERT INTO layout_items (region, state, token) VALUES ('primary', 'edge', 'eu-west');
