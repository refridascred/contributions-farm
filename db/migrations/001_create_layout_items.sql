-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, level, rank, weight) VALUES (14.79, 98, 98, 88.25);
INSERT INTO layout_items (ratio, level, rank, weight) VALUES (72.79, 65, 71, 10.69);
