-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, rank, level) VALUES (74.34, 26, 4);
INSERT INTO layout_items (ratio, rank, level) VALUES (39.4, 92, 81);
INSERT INTO layout_items (ratio, rank, level) VALUES (2.62, 31, 0);
