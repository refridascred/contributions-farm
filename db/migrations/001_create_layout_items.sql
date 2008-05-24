-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, region, ratio, active, score) VALUES (96.06, 'edge', 46.85, 98, 48.88);
INSERT INTO layout_items (weight, region, ratio, active, score) VALUES (76.63, 'stable', 23.17, 8, 48.66);
