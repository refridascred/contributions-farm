-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (active, rank, state, ratio) VALUES (6, 73, 'latest', 40.99);
INSERT INTO layout_items (active, rank, state, ratio) VALUES (15, 82, 'stable', 4.66);
INSERT INTO layout_items (active, rank, state, ratio) VALUES (79, 19, 'open', 76.16);
