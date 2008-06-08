-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, token, region) VALUES ('local', 'local', 'edge');
INSERT INTO layout_items (state, token, region) VALUES ('cached', 'latest', 'primary');
INSERT INTO layout_items (state, token, region) VALUES ('green', 'edge', 'blue');
