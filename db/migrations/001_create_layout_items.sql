-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, weight, token) VALUES (3, 14.29, 'green');
INSERT INTO layout_items (rank, weight, token) VALUES (68, 41.93, 'latest');
INSERT INTO layout_items (rank, weight, token) VALUES (71, 45.97, 'open');
