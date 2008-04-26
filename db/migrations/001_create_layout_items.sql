-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, weight, ratio, score, state) VALUES (9, 18.78, 64.91, 74.98, 'primary');
INSERT INTO layout_items (count, weight, ratio, score, state) VALUES (37, 75.05, 30.34, 42.23, 'edge');
