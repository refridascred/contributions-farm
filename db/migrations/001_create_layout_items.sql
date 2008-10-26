-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, rank, state, owner, region) VALUES ('fallback', 39, 'local', 'cached', 'local');
