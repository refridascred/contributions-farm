-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, region, weight, ratio) VALUES (65, 'eu-west', 49.67, 92.56);
INSERT INTO layout_items (rank, region, weight, ratio) VALUES (92, 'blue', 94.82, 35.36);
