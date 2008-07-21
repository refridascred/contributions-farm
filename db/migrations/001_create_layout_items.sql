-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, rank, token) VALUES (96.87, 2, 'standard');
INSERT INTO layout_items (weight, rank, token) VALUES (49.88, 77, 'eu-west');
