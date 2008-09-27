-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (active, ratio, state, rank) VALUES (18, 55.69, 'local', 24);
INSERT INTO layout_items (active, ratio, state, rank) VALUES (28, 89.65, 'standard', 71);
INSERT INTO layout_items (active, ratio, state, rank) VALUES (26, 61.01, 'stable', 8);
