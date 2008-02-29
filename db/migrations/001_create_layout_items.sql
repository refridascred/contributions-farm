-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, label) VALUES ('strict', 'fallback', 'eu-west');
INSERT INTO layout_items (owner, state, label) VALUES ('edge', 'strict', 'green');
INSERT INTO layout_items (owner, state, label) VALUES ('green', 'blue', 'standard');
