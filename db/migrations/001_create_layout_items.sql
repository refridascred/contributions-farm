-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, level, weight) VALUES (72.43, 18, 49.58);
INSERT INTO layout_items (ratio, level, weight) VALUES (1.31, 76, 7.63);
