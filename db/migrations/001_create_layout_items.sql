-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, region, count, token, level) VALUES (64, 'staging', 73, 'legacy', 50);
INSERT INTO layout_items (rank, region, count, token, level) VALUES (62, 'fallback', 38, 'latest', 24);
