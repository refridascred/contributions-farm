-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, weight, level) VALUES (59, 31.05, 6);
INSERT INTO layout_items (rank, weight, level) VALUES (75, 47.54, 24);
INSERT INTO layout_items (rank, weight, level) VALUES (24, 76.68, 35);
