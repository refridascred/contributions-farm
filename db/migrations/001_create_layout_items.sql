-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, ratio, region, rank, score) VALUES ('cached', 73.83, 'strict', 17, 64.3);
INSERT INTO layout_items (token, ratio, region, rank, score) VALUES ('stable', 21.39, 'open', 10, 20.37);
