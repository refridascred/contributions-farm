-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, rank, weight, owner) VALUES ('blue', 33, 72.61, 'latest');
INSERT INTO layout_items (region, rank, weight, owner) VALUES ('strict', 68, 93.6, 'edge');
INSERT INTO layout_items (region, rank, weight, owner) VALUES ('primary', 70, 71.02, 'primary');
