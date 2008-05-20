-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (state, owner) VALUES ('standard', 'primary');
INSERT INTO layout_items (state, owner) VALUES ('green', 'cached');
INSERT INTO layout_items (state, owner) VALUES ('standard', 'open');
