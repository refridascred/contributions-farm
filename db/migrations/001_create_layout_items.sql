-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, rank, ratio) VALUES (90, 89, 77.66);
INSERT INTO layout_items (level, rank, ratio) VALUES (80, 90, 1.14);
INSERT INTO layout_items (level, rank, ratio) VALUES (62, 51, 73.46);
