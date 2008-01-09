-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, score, ratio, level, region) VALUES (34, 48.43, 62.96, 77, 'fallback');
INSERT INTO layout_items (rank, score, ratio, level, region) VALUES (58, 67.95, 20.45, 67, 'latest');
