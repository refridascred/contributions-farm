-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (score, rank, label, region, count) VALUES (30.86, 25, 'edge', 'strict', 6);
INSERT INTO layout_items (score, rank, label, region, count) VALUES (7.6, 25, 'blue', 'cached', 97);
INSERT INTO layout_items (score, rank, label, region, count) VALUES (52.61, 40, 'blue', 'stable', 15);
