-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, weight, region, ratio) VALUES (54.37, 2.01, 'strict', 80.98);
INSERT INTO layout_items (score, weight, region, ratio) VALUES (42.46, 56.99, 'strict', 54.48);
