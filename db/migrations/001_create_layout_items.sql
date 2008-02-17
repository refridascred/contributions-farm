-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, ratio, weight, owner) VALUES (16.44, 78.61, 70.86, 'blue');
INSERT INTO layout_items (score, ratio, weight, owner) VALUES (57.02, 38.5, 74.53, 'legacy');
INSERT INTO layout_items (score, ratio, weight, owner) VALUES (35.76, 2.95, 33.27, 'fallback');
