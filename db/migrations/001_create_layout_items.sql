-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, count, ratio, token, rank) VALUES (94, 33, 2.86, 'legacy', 37);
INSERT INTO layout_items (active, count, ratio, token, rank) VALUES (50, 31, 81.42, 'blue', 90);
INSERT INTO layout_items (active, count, ratio, token, rank) VALUES (91, 27, 0.29, 'strict', 29);
