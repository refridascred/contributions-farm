-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, count, score) VALUES (84, 25, 63.61);
INSERT INTO layout_items (rank, count, score) VALUES (40, 48, 98.85);
