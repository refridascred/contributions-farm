-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, ratio, weight) VALUES (16.2, 8.93, 78.73);
INSERT INTO layout_items (score, ratio, weight) VALUES (11.9, 38.5, 44.14);
INSERT INTO layout_items (score, ratio, weight) VALUES (40.54, 63.65, 70.61);
