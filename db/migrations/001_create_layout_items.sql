-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, count, level, score) VALUES (74.36, 39, 75, 84.99);
INSERT INTO layout_items (ratio, count, level, score) VALUES (89.85, 85, 91, 56.16);
INSERT INTO layout_items (ratio, count, level, score) VALUES (20.42, 43, 1, 53.53);
