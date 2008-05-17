-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, owner, region) VALUES (7, 'open', 'latest');
INSERT INTO layout_items (rank, owner, region) VALUES (7, 'legacy', 'standard');
INSERT INTO layout_items (rank, owner, region) VALUES (59, 'edge', 'cached');
