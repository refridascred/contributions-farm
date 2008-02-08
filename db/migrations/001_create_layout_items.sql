-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (token, owner, active, state) VALUES ('green', 'primary', 23, 'fallback');
INSERT INTO layout_items (token, owner, active, state) VALUES ('standard', 'fallback', 86, 'eu-west');
INSERT INTO layout_items (token, owner, active, state) VALUES ('primary', 'cached', 89, 'edge');
