-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    ratio REAL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, rank, ratio, label, weight) VALUES (7, 98, 31.75, 'latest', 35.05);
INSERT INTO layout_items (level, rank, ratio, label, weight) VALUES (54, 19, 92.07, 'fallback', 58.31);
INSERT INTO layout_items (level, rank, ratio, label, weight) VALUES (10, 2, 37.47, 'edge', 86.9);
