-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, ratio, count) VALUES (69, 14.35, 49);
INSERT INTO layout_items (level, ratio, count) VALUES (93, 72.81, 89);
INSERT INTO layout_items (level, ratio, count) VALUES (85, 39.88, 87);
