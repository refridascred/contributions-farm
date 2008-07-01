-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, count, score, rank, token) VALUES ('cached', 28, 52.43, 98, 'local');
INSERT INTO layout_items (region, count, score, rank, token) VALUES ('stable', 22, 49.52, 62, 'primary');
INSERT INTO layout_items (region, count, score, rank, token) VALUES ('blue', 14, 36.87, 81, 'primary');
