-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, ratio, rank, owner, weight) VALUES (65, 70.05, 10, 'fallback', 96.67);
INSERT INTO layout_items (count, ratio, rank, owner, weight) VALUES (59, 7.26, 40, 'cached', 21.89);
INSERT INTO layout_items (count, ratio, rank, owner, weight) VALUES (10, 59.88, 29, 'standard', 10.7);
