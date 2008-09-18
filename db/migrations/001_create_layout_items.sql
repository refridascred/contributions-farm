-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, score, region, token, level) VALUES (0, 73.1, 'blue', 'latest', 42);
INSERT INTO layout_items (rank, score, region, token, level) VALUES (62, 2.34, 'legacy', 'legacy', 87);
INSERT INTO layout_items (rank, score, region, token, level) VALUES (12, 96.88, 'green', 'latest', 44);
