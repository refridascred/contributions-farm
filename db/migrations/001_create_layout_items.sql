-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (active, owner, state, label) VALUES (56, 'cached', 'eu-west', 'standard');
INSERT INTO layout_items (active, owner, state, label) VALUES (6, 'fallback', 'staging', 'stable');
INSERT INTO layout_items (active, owner, state, label) VALUES (35, 'eu-west', 'latest', 'eu-west');
