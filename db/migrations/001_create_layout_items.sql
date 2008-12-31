-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, score, rank, count) VALUES ('open', 84.59, 18, 9);
INSERT INTO layout_items (region, score, rank, count) VALUES ('blue', 26.63, 94, 33);
INSERT INTO layout_items (region, score, rank, count) VALUES ('stable', 12.5, 63, 6);
