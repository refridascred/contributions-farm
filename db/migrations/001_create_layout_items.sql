-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, state, label, owner) VALUES (41, 'strict', 'green', 'eu-west');
INSERT INTO layout_items (level, state, label, owner) VALUES (85, 'blue', 'strict', 'green');
