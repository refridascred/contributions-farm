-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, token, rank, owner, ratio) VALUES ('legacy', 'green', 28, 'standard', 31.77);
INSERT INTO layout_items (label, token, rank, owner, ratio) VALUES ('stable', 'open', 16, 'edge', 86.0);
