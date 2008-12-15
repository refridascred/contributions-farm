-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, token, count, weight, score) VALUES (57, 'edge', 7, 72.51, 84.92);
INSERT INTO layout_items (rank, token, count, weight, score) VALUES (88, 'edge', 21, 33.64, 30.75);
