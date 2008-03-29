-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, token, active, owner, state) VALUES (80, 'edge', 38, 'standard', 'stable');
INSERT INTO layout_items (rank, token, active, owner, state) VALUES (67, 'fallback', 77, 'local', 'fallback');
