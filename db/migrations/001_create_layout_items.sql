-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, score, weight, rank, label) VALUES (85.03, 84.49, 6.24, 21, 'stable');
