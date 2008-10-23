-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, level, count) VALUES (16.62, 47, 88);
INSERT INTO layout_items (ratio, level, count) VALUES (34.45, 19, 1);
INSERT INTO layout_items (ratio, level, count) VALUES (91.86, 82, 40);
