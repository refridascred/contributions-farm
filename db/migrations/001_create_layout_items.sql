-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, count, state, token) VALUES (70, 10, 'green', 'local');
INSERT INTO layout_items (active, count, state, token) VALUES (11, 46, 'open', 'staging');
INSERT INTO layout_items (active, count, state, token) VALUES (55, 5, 'staging', 'legacy');
