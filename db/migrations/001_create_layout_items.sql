-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, region, weight, rank, count) VALUES ('staging', 'edge', 27.12, 21, 30);
INSERT INTO layout_items (label, region, weight, rank, count) VALUES ('stable', 'eu-west', 2.66, 53, 46);
