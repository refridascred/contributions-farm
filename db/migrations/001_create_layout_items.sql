-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, active, state, owner) VALUES (86, 88, 'legacy', 'stable');
INSERT INTO layout_items (rank, active, state, owner) VALUES (6, 24, 'latest', 'green');
INSERT INTO layout_items (rank, active, state, owner) VALUES (86, 90, 'cached', 'standard');
