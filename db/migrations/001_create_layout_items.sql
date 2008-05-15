-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, token) VALUES ('green', 'fallback', 'latest');
INSERT INTO layout_items (owner, state, token) VALUES ('blue', 'latest', 'open');
INSERT INTO layout_items (owner, state, token) VALUES ('blue', 'blue', 'cached');
