-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, active, level, count, score) VALUES (89.64, 30, 59, 52, 25.13);
INSERT INTO layout_items (ratio, active, level, count, score) VALUES (37.92, 46, 29, 35, 45.77);
INSERT INTO layout_items (ratio, active, level, count, score) VALUES (80.5, 35, 61, 30, 82.69);
