-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, ratio, rank, count, active) VALUES (0, 80.48, 4, 5, 67);
INSERT INTO layout_items (level, ratio, rank, count, active) VALUES (17, 75.54, 14, 44, 89);
INSERT INTO layout_items (level, ratio, rank, count, active) VALUES (28, 72.5, 38, 74, 8);
