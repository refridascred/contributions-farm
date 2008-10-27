-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (owner, rank, state) VALUES ('legacy', 19, 'stable');
INSERT INTO layout_items (owner, rank, state) VALUES ('legacy', 58, 'local');
INSERT INTO layout_items (owner, rank, state) VALUES ('legacy', 61, 'standard');
