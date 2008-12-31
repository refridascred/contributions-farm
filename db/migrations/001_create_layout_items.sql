-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (owner, count, level, ratio, rank) VALUES ('primary', 3, 58, 43.08, 83);
INSERT INTO layout_items (owner, count, level, ratio, rank) VALUES ('staging', 25, 33, 59.47, 0);
