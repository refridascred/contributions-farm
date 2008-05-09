-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (state, owner, count) VALUES ('local', 'cached', 77);
INSERT INTO layout_items (state, owner, count) VALUES ('staging', 'strict', 10);
INSERT INTO layout_items (state, owner, count) VALUES ('legacy', 'strict', 48);
