-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, token, state) VALUES ('legacy', 'primary', 'cached');
INSERT INTO layout_items (owner, token, state) VALUES ('local', 'cached', 'primary');
INSERT INTO layout_items (owner, token, state) VALUES ('standard', 'cached', 'legacy');
