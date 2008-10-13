-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, owner, active, rank) VALUES ('staging', 'latest', 64, 92);
INSERT INTO layout_items (state, owner, active, rank) VALUES ('fallback', 'eu-west', 78, 95);
INSERT INTO layout_items (state, owner, active, rank) VALUES ('green', 'strict', 88, 18);
