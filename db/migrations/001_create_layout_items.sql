-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (active, label, state, token) VALUES (38, 'latest', 'latest', 'strict');
INSERT INTO layout_items (active, label, state, token) VALUES (46, 'standard', 'stable', 'edge');
INSERT INTO layout_items (active, label, state, token) VALUES (66, 'blue', 'open', 'standard');
