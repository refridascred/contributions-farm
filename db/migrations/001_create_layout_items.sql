-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, region, rank, ratio) VALUES (92, 'latest', 99, 50.85);
INSERT INTO layout_items (count, region, rank, ratio) VALUES (40, 'strict', 24, 81.81);
