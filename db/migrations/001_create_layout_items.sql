-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, state, level, token, owner) VALUES (45, 'stable', 34, 'local', 'stable');
INSERT INTO layout_items (rank, state, level, token, owner) VALUES (1, 'primary', 85, 'stable', 'primary');
