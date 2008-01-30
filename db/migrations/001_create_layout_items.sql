-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, rank, count, score) VALUES (5, 15, 86, 65.67);
INSERT INTO layout_items (level, rank, count, score) VALUES (78, 72, 70, 43.91);
INSERT INTO layout_items (level, rank, count, score) VALUES (3, 40, 88, 53.56);
