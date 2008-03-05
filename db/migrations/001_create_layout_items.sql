-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, rank, level, count, score) VALUES (59.78, 71, 27, 38, 32.84);
INSERT INTO layout_items (weight, rank, level, count, score) VALUES (80.7, 19, 67, 3, 32.85);
INSERT INTO layout_items (weight, rank, level, count, score) VALUES (57.18, 15, 81, 86, 25.59);
