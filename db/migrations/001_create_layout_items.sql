-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, ratio, weight) VALUES (15, 60.75, 32.91);
INSERT INTO layout_items (rank, ratio, weight) VALUES (43, 14.87, 29.72);
