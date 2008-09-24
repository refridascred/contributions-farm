-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, level, ratio, rank) VALUES (42, 22, 92.34, 11);
INSERT INTO layout_items (count, level, ratio, rank) VALUES (1, 47, 82.99, 9);
INSERT INTO layout_items (count, level, ratio, rank) VALUES (77, 14, 91.02, 65);
