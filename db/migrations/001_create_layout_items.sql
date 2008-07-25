-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, state, active) VALUES (30, 'green', 4);
INSERT INTO layout_items (rank, state, active) VALUES (45, 'blue', 14);
INSERT INTO layout_items (rank, state, active) VALUES (74, 'stable', 99);
