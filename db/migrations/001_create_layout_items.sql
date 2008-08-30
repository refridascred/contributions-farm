-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, count, ratio, rank, score) VALUES (14, 18, 80.1, 94, 17.36);
INSERT INTO layout_items (level, count, ratio, rank, score) VALUES (87, 97, 10.99, 67, 28.82);
INSERT INTO layout_items (level, count, ratio, rank, score) VALUES (82, 14, 93.9, 57, 26.01);
