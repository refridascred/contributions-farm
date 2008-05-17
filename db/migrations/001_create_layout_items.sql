-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, ratio, rank) VALUES (39, 72.54, 93);
INSERT INTO layout_items (level, ratio, rank) VALUES (59, 40.96, 27);
