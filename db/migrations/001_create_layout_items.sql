-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (owner, score, ratio, count, rank) VALUES ('fallback', 68.12, 90.91, 80, 37);
INSERT INTO layout_items (owner, score, ratio, count, rank) VALUES ('green', 76.96, 57.27, 45, 30);
