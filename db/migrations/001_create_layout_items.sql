-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, region, label, rank, ratio) VALUES (41, 'stable', 'cached', 28, 27.03);
INSERT INTO layout_items (count, region, label, rank, ratio) VALUES (34, 'staging', 'legacy', 5, 35.26);
INSERT INTO layout_items (count, region, label, rank, ratio) VALUES (41, 'staging', 'edge', 20, 86.15);
