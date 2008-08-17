-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, rank, owner, label) VALUES ('stable', 81, 'eu-west', 'primary');
INSERT INTO layout_items (state, rank, owner, label) VALUES ('blue', 80, 'edge', 'green');
