-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, rank, active, owner) VALUES ('standard', 47, 0, 'latest');
INSERT INTO layout_items (token, rank, active, owner) VALUES ('blue', 10, 91, 'cached');
