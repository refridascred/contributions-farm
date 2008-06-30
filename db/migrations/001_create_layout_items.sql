-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, count, ratio, level) VALUES (33, 76, 3.37, 9);
INSERT INTO layout_items (rank, count, ratio, level) VALUES (0, 46, 70.3, 28);
