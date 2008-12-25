-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, owner, rank, weight, score) VALUES ('strict', 'strict', 71, 72.99, 54.31);
INSERT INTO layout_items (region, owner, rank, weight, score) VALUES ('standard', 'stable', 93, 82.85, 80.8);
