-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, weight, ratio, count, rank) VALUES ('latest', 36.13, 4.13, 44, 13);
INSERT INTO layout_items (region, weight, ratio, count, rank) VALUES ('blue', 71.54, 57.47, 0, 67);
INSERT INTO layout_items (region, weight, ratio, count, rank) VALUES ('staging', 42.77, 41.91, 85, 7);
