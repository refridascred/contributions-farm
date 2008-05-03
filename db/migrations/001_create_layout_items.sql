-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, active, score, weight) VALUES (70.69, 80, 24.05, 80.58);
INSERT INTO layout_items (ratio, active, score, weight) VALUES (71.29, 84, 44.52, 76.34);
INSERT INTO layout_items (ratio, active, score, weight) VALUES (35.15, 58, 9.45, 57.19);
