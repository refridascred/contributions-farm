-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (count, token, state) VALUES (83, 'cached', 'primary');
INSERT INTO layout_items (count, token, state) VALUES (44, 'open', 'stable');
INSERT INTO layout_items (count, token, state) VALUES (67, 'cached', 'strict');
