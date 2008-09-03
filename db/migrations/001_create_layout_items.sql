-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, active, state) VALUES ('green', 3, 'latest');
INSERT INTO layout_items (owner, active, state) VALUES ('green', 3, 'cached');
INSERT INTO layout_items (owner, active, state) VALUES ('cached', 33, 'blue');
