-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, level, count, ratio) VALUES (5.11, 50, 83, 72.63);
INSERT INTO layout_items (weight, level, count, ratio) VALUES (37.47, 70, 6, 4.06);
INSERT INTO layout_items (weight, level, count, ratio) VALUES (61.26, 52, 88, 64.07);
