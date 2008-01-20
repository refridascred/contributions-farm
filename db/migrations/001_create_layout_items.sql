-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, ratio, score, active, rank) VALUES (28, 58.65, 74.1, 89, 68);
INSERT INTO layout_items (count, ratio, score, active, rank) VALUES (38, 28.9, 80.22, 59, 22);
INSERT INTO layout_items (count, ratio, score, active, rank) VALUES (66, 79.96, 46.07, 9, 94);
