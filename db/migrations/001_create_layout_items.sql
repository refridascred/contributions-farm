-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, weight, level) VALUES (53, 4.43, 83);
INSERT INTO layout_items (rank, weight, level) VALUES (26, 44.05, 0);
INSERT INTO layout_items (rank, weight, level) VALUES (98, 54.06, 0);
