-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, region, score, token, owner) VALUES (73, 'edge', 8.31, 'local', 'edge');
INSERT INTO layout_items (rank, region, score, token, owner) VALUES (52, 'eu-west', 93.29, 'cached', 'blue');
INSERT INTO layout_items (rank, region, score, token, owner) VALUES (52, 'stable', 34.2, 'blue', 'local');
