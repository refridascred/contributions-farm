-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, count, weight, region) VALUES (6.12, 76, 8.68, 'local');
INSERT INTO layout_items (score, count, weight, region) VALUES (15.94, 47, 0.07, 'standard');
INSERT INTO layout_items (score, count, weight, region) VALUES (45.88, 81, 48.11, 'fallback');
