-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, count, state) VALUES (18, 31, 'primary');
INSERT INTO layout_items (active, count, state) VALUES (15, 97, 'latest');
INSERT INTO layout_items (active, count, state) VALUES (28, 25, 'fallback');
