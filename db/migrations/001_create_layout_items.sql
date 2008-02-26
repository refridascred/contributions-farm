-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, ratio, level, weight) VALUES (55, 77.42, 80, 59.72);
INSERT INTO layout_items (rank, ratio, level, weight) VALUES (37, 55.58, 3, 0.2);
