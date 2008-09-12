-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (active, owner, rank, ratio) VALUES (20, 'edge', 14, 65.04);
INSERT INTO layout_items (active, owner, rank, ratio) VALUES (49, 'stable', 58, 23.37);
