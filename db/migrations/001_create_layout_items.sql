-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, count, rank, ratio) VALUES (90, 5, 30, 29.44);
INSERT INTO layout_items (level, count, rank, ratio) VALUES (42, 14, 64, 49.99);
