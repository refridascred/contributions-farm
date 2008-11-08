-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, count, state, owner, label) VALUES (48.56, 25, 'eu-west', 'stable', 'strict');
INSERT INTO layout_items (weight, count, state, owner, label) VALUES (10.99, 77, 'cached', 'open', 'edge');
