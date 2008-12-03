-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, active, rank, owner) VALUES (41, 72, 70, 'fallback');
INSERT INTO layout_items (count, active, rank, owner) VALUES (92, 52, 98, 'latest');
INSERT INTO layout_items (count, active, rank, owner) VALUES (36, 30, 1, 'edge');
