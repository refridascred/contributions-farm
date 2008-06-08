-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, owner, label, rank, token) VALUES ('staging', 'green', 'cached', 20, 'green');
INSERT INTO layout_items (state, owner, label, rank, token) VALUES ('edge', 'edge', 'fallback', 39, 'standard');
