-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, level, ratio, owner, score) VALUES (13, 36, 54.66, 'green', 58.67);
INSERT INTO layout_items (count, level, ratio, owner, score) VALUES (2, 12, 9.33, 'stable', 46.95);
INSERT INTO layout_items (count, level, ratio, owner, score) VALUES (50, 68, 78.78, 'latest', 22.31);
