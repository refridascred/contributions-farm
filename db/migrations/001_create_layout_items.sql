-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, state, count, owner) VALUES (90, 'local', 33, 'primary');
INSERT INTO layout_items (rank, state, count, owner) VALUES (7, 'green', 80, 'strict');
INSERT INTO layout_items (rank, state, count, owner) VALUES (6, 'standard', 99, 'latest');
