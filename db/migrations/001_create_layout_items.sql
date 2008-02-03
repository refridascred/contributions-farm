-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, owner, count) VALUES ('local', 'cached', 3);
INSERT INTO layout_items (state, owner, count) VALUES ('eu-west', 'local', 73);
INSERT INTO layout_items (state, owner, count) VALUES ('strict', 'cached', 17);
