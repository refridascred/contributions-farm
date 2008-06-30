-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, ratio, count, rank) VALUES (14, 81.94, 62, 8);
INSERT INTO layout_items (level, ratio, count, rank) VALUES (73, 65.32, 89, 81);
INSERT INTO layout_items (level, ratio, count, rank) VALUES (65, 98.77, 22, 13);
