-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, score, level, token) VALUES (48.26, 54.5, 84, 'stable');
INSERT INTO layout_items (weight, score, level, token) VALUES (61.42, 10.17, 77, 'strict');
INSERT INTO layout_items (weight, score, level, token) VALUES (98.86, 20.63, 37, 'blue');
