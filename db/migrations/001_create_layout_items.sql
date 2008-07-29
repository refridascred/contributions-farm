-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, level, count) VALUES (32.84, 25, 49);
INSERT INTO layout_items (ratio, level, count) VALUES (26.1, 53, 33);
INSERT INTO layout_items (ratio, level, count) VALUES (51.85, 0, 81);
