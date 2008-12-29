-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (active, owner, state) VALUES (59, 'legacy', 'cached');
INSERT INTO layout_items (active, owner, state) VALUES (67, 'standard', 'strict');
INSERT INTO layout_items (active, owner, state) VALUES (36, 'local', 'strict');
