-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, rank, weight, ratio) VALUES ('eu-west', 3, 68.68, 84.62);
INSERT INTO layout_items (region, rank, weight, ratio) VALUES ('strict', 81, 56.99, 4.24);
