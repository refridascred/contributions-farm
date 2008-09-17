-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, rank, ratio, score) VALUES (12, 19, 69.72, 85.91);
INSERT INTO layout_items (level, rank, ratio, score) VALUES (65, 55, 1.02, 47.27);
INSERT INTO layout_items (level, rank, ratio, score) VALUES (49, 24, 72.3, 46.11);
