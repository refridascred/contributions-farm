-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, weight, rank) VALUES (87.62, 28.91, 1);
INSERT INTO layout_items (ratio, weight, rank) VALUES (32.76, 78.42, 13);
INSERT INTO layout_items (ratio, weight, rank) VALUES (33.31, 35.52, 60);
