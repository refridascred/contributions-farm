-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (score, owner, ratio, rank, weight) VALUES (64.73, 'blue', 31.26, 95, 38.04);
INSERT INTO layout_items (score, owner, ratio, rank, weight) VALUES (85.29, 'primary', 33.96, 37, 5.71);
INSERT INTO layout_items (score, owner, ratio, rank, weight) VALUES (41.56, 'legacy', 40.65, 52, 48.95);
