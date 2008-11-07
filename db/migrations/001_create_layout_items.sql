-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, token, count, active) VALUES ('local', 'eu-west', 'eu-west', 70, 2);
INSERT INTO layout_items (owner, state, token, count, active) VALUES ('primary', 'stable', 'primary', 68, 42);
INSERT INTO layout_items (owner, state, token, count, active) VALUES ('stable', 'edge', 'open', 27, 89);
