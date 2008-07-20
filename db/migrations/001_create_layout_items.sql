-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, region, rank) VALUES (25.09, 'legacy', 44);
INSERT INTO layout_items (weight, region, rank) VALUES (9.56, 'green', 60);
INSERT INTO layout_items (weight, region, rank) VALUES (83.15, 'legacy', 28);
