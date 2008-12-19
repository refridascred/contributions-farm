-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, count, ratio, rank) VALUES ('cached', 58, 23.38, 61);
INSERT INTO layout_items (region, count, ratio, rank) VALUES ('edge', 76, 91.44, 68);
INSERT INTO layout_items (region, count, ratio, rank) VALUES ('cached', 69, 23.98, 99);
