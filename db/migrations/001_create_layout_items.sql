-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (rank, count, region, level, weight) VALUES (2, 45, 'fallback', 92, 39.31);
INSERT INTO layout_items (rank, count, region, level, weight) VALUES (51, 33, 'strict', 52, 16.41);
INSERT INTO layout_items (rank, count, region, level, weight) VALUES (46, 74, 'strict', 46, 93.46);
