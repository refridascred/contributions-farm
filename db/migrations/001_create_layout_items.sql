-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, rank, count, score) VALUES (26.71, 44, 35, 18.6);
INSERT INTO layout_items (ratio, rank, count, score) VALUES (47.63, 0, 32, 66.96);
INSERT INTO layout_items (ratio, rank, count, score) VALUES (22.74, 35, 22, 56.83);
