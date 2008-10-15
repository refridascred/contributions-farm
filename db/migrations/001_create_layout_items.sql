-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, owner, state, count) VALUES (87, 'cached', 'latest', 1);
INSERT INTO layout_items (active, owner, state, count) VALUES (58, 'eu-west', 'open', 65);
INSERT INTO layout_items (active, owner, state, count) VALUES (51, 'legacy', 'cached', 50);
