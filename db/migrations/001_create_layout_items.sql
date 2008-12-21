-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, region, weight, count) VALUES (42, 'fallback', 5.91, 45);
INSERT INTO layout_items (rank, region, weight, count) VALUES (98, 'standard', 96.53, 54);
INSERT INTO layout_items (rank, region, weight, count) VALUES (62, 'strict', 7.91, 20);
