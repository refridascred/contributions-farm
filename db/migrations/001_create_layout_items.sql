-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, state, owner, level) VALUES (92, 'local', 'primary', 37);
INSERT INTO layout_items (count, state, owner, level) VALUES (96, 'edge', 'green', 88);
INSERT INTO layout_items (count, state, owner, level) VALUES (11, 'eu-west', 'cached', 37);
