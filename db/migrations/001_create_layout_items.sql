-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (count, state, token, owner) VALUES (6, 'staging', 'cached', 'stable');
INSERT INTO layout_items (count, state, token, owner) VALUES (73, 'legacy', 'primary', 'local');
INSERT INTO layout_items (count, state, token, owner) VALUES (37, 'cached', 'staging', 'stable');
