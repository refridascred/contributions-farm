-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, rank, weight) VALUES (36.53, 91, 57.53);
INSERT INTO layout_items (ratio, rank, weight) VALUES (29.77, 62, 28.71);
INSERT INTO layout_items (ratio, rank, weight) VALUES (98.42, 63, 64.59);
