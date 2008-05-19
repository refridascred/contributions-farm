-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, count, level, ratio) VALUES (85.88, 49, 3, 15.15);
INSERT INTO layout_items (weight, count, level, ratio) VALUES (9.26, 16, 92, 4.5);
INSERT INTO layout_items (weight, count, level, ratio) VALUES (89.48, 14, 7, 3.52);
