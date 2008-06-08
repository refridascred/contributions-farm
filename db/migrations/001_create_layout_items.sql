-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, state, token, count, active) VALUES (90, 'standard', 'staging', 29, 7);
INSERT INTO layout_items (rank, state, token, count, active) VALUES (5, 'edge', 'green', 11, 53);
INSERT INTO layout_items (rank, state, token, count, active) VALUES (58, 'local', 'green', 75, 52);
