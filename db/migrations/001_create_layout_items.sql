-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, owner, rank, state, active) VALUES ('local', 'cached', 43, 'edge', 31);
INSERT INTO layout_items (token, owner, rank, state, active) VALUES ('primary', 'latest', 87, 'local', 90);
