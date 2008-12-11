-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, state, active, owner, label) VALUES (26, 'primary', 3, 'strict', 'primary');
INSERT INTO layout_items (level, state, active, owner, label) VALUES (6, 'staging', 37, 'eu-west', 'strict');
