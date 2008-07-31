-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, weight, rank, level) VALUES (28, 80.49, 35, 9);
INSERT INTO layout_items (count, weight, rank, level) VALUES (95, 23.81, 50, 69);
INSERT INTO layout_items (count, weight, rank, level) VALUES (51, 76.44, 50, 2);
