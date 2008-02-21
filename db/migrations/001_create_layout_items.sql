-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, score, rank) VALUES (90, 16.24, 98);
INSERT INTO layout_items (count, score, rank) VALUES (36, 4.37, 19);
INSERT INTO layout_items (count, score, rank) VALUES (20, 22.62, 24);
