-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, rank, score, active) VALUES (47.32, 6, 44.99, 18);
INSERT INTO layout_items (ratio, rank, score, active) VALUES (65.04, 89, 67.53, 90);
INSERT INTO layout_items (ratio, rank, score, active) VALUES (68.04, 57, 13.49, 14);
