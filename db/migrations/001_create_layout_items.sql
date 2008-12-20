-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, token, owner, rank, score) VALUES (30, 'staging', 'strict', 73, 88.49);
INSERT INTO layout_items (level, token, owner, rank, score) VALUES (42, 'eu-west', 'fallback', 13, 16.25);
INSERT INTO layout_items (level, token, owner, rank, score) VALUES (67, 'legacy', 'eu-west', 38, 32.47);
