-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, level, count, rank) VALUES (8.17, 91, 14, 10);
INSERT INTO layout_items (ratio, level, count, rank) VALUES (96.31, 21, 42, 82);
INSERT INTO layout_items (ratio, level, count, rank) VALUES (84.33, 46, 7, 35);
