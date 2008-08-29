-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, owner, state, token, label) VALUES (22, 'standard', 'cached', 'green', 'fallback');
INSERT INTO layout_items (rank, owner, state, token, label) VALUES (72, 'standard', 'strict', 'latest', 'stable');
