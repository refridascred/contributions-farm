-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (count, active, owner, state, token) VALUES (74, 92, 'cached', 'latest', 'open');
INSERT INTO layout_items (count, active, owner, state, token) VALUES (49, 62, 'eu-west', 'stable', 'strict');
INSERT INTO layout_items (count, active, owner, state, token) VALUES (42, 87, 'primary', 'eu-west', 'standard');
