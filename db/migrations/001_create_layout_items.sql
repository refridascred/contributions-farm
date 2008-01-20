-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, rank, count, region) VALUES (33.71, 12, 81, 'edge');
INSERT INTO layout_items (ratio, rank, count, region) VALUES (78.17, 69, 26, 'edge');
INSERT INTO layout_items (ratio, rank, count, region) VALUES (30.93, 27, 23, 'fallback');
