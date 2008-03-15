-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, count, rank) VALUES (64.28, 48, 11);
INSERT INTO layout_items (score, count, rank) VALUES (36.23, 10, 64);
INSERT INTO layout_items (score, count, rank) VALUES (69.55, 82, 5);
