-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, ratio, level, rank) VALUES (74, 98.26, 25, 24);
INSERT INTO layout_items (count, ratio, level, rank) VALUES (45, 63.0, 96, 3);
INSERT INTO layout_items (count, ratio, level, rank) VALUES (47, 56.33, 34, 82);
