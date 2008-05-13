-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, rank, count, level, ratio) VALUES (52.61, 64, 94, 42, 38.7);
INSERT INTO layout_items (score, rank, count, level, ratio) VALUES (23.73, 83, 19, 39, 66.29);
