-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, state, active, count, rank) VALUES (51, 'edge', 52, 7, 10);
INSERT INTO layout_items (level, state, active, count, rank) VALUES (59, 'cached', 35, 37, 70);
INSERT INTO layout_items (level, state, active, count, rank) VALUES (68, 'strict', 11, 57, 11);
