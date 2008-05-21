-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (region, score, weight) VALUES ('cached', 57.84, 76.61);
INSERT INTO layout_items (region, score, weight) VALUES ('edge', 2.51, 69.64);
INSERT INTO layout_items (region, score, weight) VALUES ('legacy', 63.25, 62.73);
