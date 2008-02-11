-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (active, token, state) VALUES (7, 'local', 'cached');
INSERT INTO layout_items (active, token, state) VALUES (43, 'latest', 'standard');
INSERT INTO layout_items (active, token, state) VALUES (5, 'blue', 'staging');
