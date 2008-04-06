-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, ratio, level, count) VALUES (45, 5.65, 62, 59);
INSERT INTO layout_items (rank, ratio, level, count) VALUES (15, 24.29, 97, 74);
INSERT INTO layout_items (rank, ratio, level, count) VALUES (93, 36.69, 49, 86);
