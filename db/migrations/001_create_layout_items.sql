-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, state, rank) VALUES (35, 'blue', 91);
INSERT INTO layout_items (count, state, rank) VALUES (6, 'local', 58);
INSERT INTO layout_items (count, state, rank) VALUES (70, 'fallback', 2);
