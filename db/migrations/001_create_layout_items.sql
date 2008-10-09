-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, active, level, rank, weight) VALUES (15.88, 54, 17, 76, 54.36);
INSERT INTO layout_items (ratio, active, level, rank, weight) VALUES (30.62, 86, 80, 16, 68.89);
INSERT INTO layout_items (ratio, active, level, rank, weight) VALUES (42.49, 69, 67, 56, 74.15);
