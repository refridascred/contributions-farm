-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, state, active, owner) VALUES ('strict', 'fallback', 63, 'standard');
INSERT INTO layout_items (token, state, active, owner) VALUES ('stable', 'open', 9, 'primary');
INSERT INTO layout_items (token, state, active, owner) VALUES ('strict', 'stable', 92, 'stable');
