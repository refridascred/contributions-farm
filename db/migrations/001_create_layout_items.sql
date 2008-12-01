-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (owner, rank, ratio, count, level) VALUES ('blue', 74, 98.47, 93, 76);
INSERT INTO layout_items (owner, rank, ratio, count, level) VALUES ('stable', 95, 23.23, 5, 39);
INSERT INTO layout_items (owner, rank, ratio, count, level) VALUES ('strict', 10, 3.33, 13, 9);
