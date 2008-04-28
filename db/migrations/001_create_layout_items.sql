-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, owner, ratio, rank, count) VALUES (61, 'primary', 25.23, 17, 7);
INSERT INTO layout_items (level, owner, ratio, rank, count) VALUES (36, 'strict', 56.66, 74, 34);
INSERT INTO layout_items (level, owner, ratio, rank, count) VALUES (91, 'edge', 74.81, 14, 94);
