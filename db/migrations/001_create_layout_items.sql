-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    rank INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, weight, rank, region, ratio) VALUES ('latest', 15.1, 90, 'edge', 70.86);
INSERT INTO layout_items (label, weight, rank, region, ratio) VALUES ('strict', 35.25, 14, 'staging', 90.05);
