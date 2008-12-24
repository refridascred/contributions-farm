-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, active, ratio, score, weight) VALUES ('strict', 0, 52.03, 85.83, 63.92);
INSERT INTO layout_items (region, active, ratio, score, weight) VALUES ('edge', 67, 74.06, 37.56, 25.53);
