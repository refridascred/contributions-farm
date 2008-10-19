-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, score, region, ratio, weight) VALUES ('latest', 92.37, 'stable', 67.03, 61.72);
INSERT INTO layout_items (label, score, region, ratio, weight) VALUES ('standard', 93.95, 'local', 35.76, 27.06);
INSERT INTO layout_items (label, score, region, ratio, weight) VALUES ('green', 28.55, 'latest', 88.42, 0.76);
