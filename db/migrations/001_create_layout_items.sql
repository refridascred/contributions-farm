-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, weight, rank) VALUES ('latest', 64.39, 5);
INSERT INTO layout_items (label, weight, rank) VALUES ('cached', 66.99, 98);
INSERT INTO layout_items (label, weight, rank) VALUES ('blue', 81.5, 95);
