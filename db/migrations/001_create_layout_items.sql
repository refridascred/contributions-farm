-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, owner, count, rank) VALUES ('latest', 'cached', 19, 53);
INSERT INTO layout_items (state, owner, count, rank) VALUES ('stable', 'blue', 79, 24);
INSERT INTO layout_items (state, owner, count, rank) VALUES ('standard', 'edge', 74, 60);
