-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, weight, count, ratio, owner) VALUES (63, 81.24, 40, 73.13, 'primary');
INSERT INTO layout_items (level, weight, count, ratio, owner) VALUES (8, 57.14, 94, 49.9, 'fallback');
INSERT INTO layout_items (level, weight, count, ratio, owner) VALUES (9, 5.22, 61, 88.18, 'legacy');
