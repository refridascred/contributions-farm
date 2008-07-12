-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, count, score, level, active) VALUES (70, 4, 4.74, 35, 30);
INSERT INTO layout_items (rank, count, score, level, active) VALUES (91, 90, 53.66, 7, 92);
INSERT INTO layout_items (rank, count, score, level, active) VALUES (73, 63, 77.8, 44, 38);
