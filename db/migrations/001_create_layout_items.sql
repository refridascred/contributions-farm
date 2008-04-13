-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight, score, ratio) VALUES (87, 36.41, 27.36, 64.91);
INSERT INTO layout_items (level, weight, score, ratio) VALUES (70, 17.56, 44.56, 2.35);
