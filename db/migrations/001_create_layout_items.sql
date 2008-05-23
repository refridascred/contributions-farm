-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, score, count, ratio, token) VALUES (41.56, 7.75, 29, 89.94, 'blue');
INSERT INTO layout_items (weight, score, count, ratio, token) VALUES (42.97, 13.52, 62, 79.81, 'staging');
INSERT INTO layout_items (weight, score, count, ratio, token) VALUES (69.59, 26.57, 35, 17.39, 'strict');
