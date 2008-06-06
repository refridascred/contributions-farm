-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, state, active, rank) VALUES (12, 'staging', 98, 98);
INSERT INTO layout_items (count, state, active, rank) VALUES (77, 'eu-west', 43, 6);
INSERT INTO layout_items (count, state, active, rank) VALUES (13, 'cached', 8, 8);
