-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, state, count, score) VALUES (27, 'strict', 10, 54.43);
INSERT INTO layout_items (rank, state, count, score) VALUES (77, 'stable', 93, 15.7);
INSERT INTO layout_items (rank, state, count, score) VALUES (89, 'stable', 35, 8.37);
