-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, owner, active, token, rank) VALUES ('staging', 'staging', 84, 'latest', 7);
INSERT INTO layout_items (state, owner, active, token, rank) VALUES ('legacy', 'fallback', 84, 'open', 38);
