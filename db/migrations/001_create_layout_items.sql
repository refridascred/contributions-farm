-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, score, rank, count) VALUES (64, 83.32, 15, 16);
INSERT INTO layout_items (level, score, rank, count) VALUES (66, 42.58, 0, 42);
INSERT INTO layout_items (level, score, rank, count) VALUES (14, 33.96, 79, 87);
