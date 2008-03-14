-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (active, state, token, owner, count) VALUES (99, 'open', 'standard', 'latest', 71);
INSERT INTO layout_items (active, state, token, owner, count) VALUES (33, 'stable', 'legacy', 'standard', 78);
