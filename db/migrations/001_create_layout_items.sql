-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (active, rank, region, score, weight) VALUES (42, 27, 'latest', 5.68, 9.87);
INSERT INTO layout_items (active, rank, region, score, weight) VALUES (1, 78, 'open', 50.69, 40.75);
INSERT INTO layout_items (active, rank, region, score, weight) VALUES (43, 50, 'local', 21.91, 29.81);
