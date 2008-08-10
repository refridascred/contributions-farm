-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, state, active, rank) VALUES (86.33, 'green', 33, 7);
INSERT INTO layout_items (ratio, state, active, rank) VALUES (30.22, 'cached', 86, 57);
INSERT INTO layout_items (ratio, state, active, rank) VALUES (80.11, 'local', 91, 49);
