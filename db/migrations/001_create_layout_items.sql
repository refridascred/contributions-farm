-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, score, ratio, weight) VALUES (56, 42.51, 23.75, 69.36);
INSERT INTO layout_items (level, score, ratio, weight) VALUES (50, 92.95, 47.65, 32.0);
INSERT INTO layout_items (level, score, ratio, weight) VALUES (46, 18.91, 18.86, 82.47);
