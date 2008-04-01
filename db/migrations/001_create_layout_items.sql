-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, ratio, rank, level, count) VALUES ('green', 50.37, 85, 28, 72);
INSERT INTO layout_items (token, ratio, rank, level, count) VALUES ('cached', 19.33, 86, 38, 14);
INSERT INTO layout_items (token, ratio, rank, level, count) VALUES ('edge', 70.35, 72, 57, 66);
