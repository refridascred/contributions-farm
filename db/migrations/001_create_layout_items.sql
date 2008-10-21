-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (score, ratio, rank) VALUES (26.73, 58.0, 22);
INSERT INTO layout_items (score, ratio, rank) VALUES (49.57, 34.61, 97);
