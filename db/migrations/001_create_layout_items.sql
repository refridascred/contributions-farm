-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, rank, ratio) VALUES (86.7, 53, 22.78);
INSERT INTO layout_items (weight, rank, ratio) VALUES (34.26, 27, 40.87);
