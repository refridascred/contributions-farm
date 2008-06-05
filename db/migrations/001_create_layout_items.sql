-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, score, ratio, weight, rank) VALUES (21, 14.3, 27.99, 97.17, 71);
INSERT INTO layout_items (level, score, ratio, weight, rank) VALUES (71, 77.93, 73.77, 61.27, 3);
INSERT INTO layout_items (level, score, ratio, weight, rank) VALUES (71, 12.36, 73.08, 72.02, 99);
