-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, weight, region) VALUES (23, 13.46, 'green');
INSERT INTO layout_items (rank, weight, region) VALUES (57, 57.16, 'strict');
INSERT INTO layout_items (rank, weight, region) VALUES (73, 57.32, 'green');
