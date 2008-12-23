-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (score, rank, owner, label) VALUES (44.87, 9, 'legacy', 'legacy');
INSERT INTO layout_items (score, rank, owner, label) VALUES (19.73, 54, 'latest', 'standard');
