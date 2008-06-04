-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, level, weight, rank) VALUES ('staging', 67, 44.89, 8);
INSERT INTO layout_items (region, level, weight, rank) VALUES ('edge', 10, 41.86, 14);
