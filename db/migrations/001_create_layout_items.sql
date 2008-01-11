-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, token, count, score) VALUES (98, 'cached', 76, 97.42);
INSERT INTO layout_items (rank, token, count, score) VALUES (21, 'open', 5, 98.74);
INSERT INTO layout_items (rank, token, count, score) VALUES (40, 'edge', 63, 12.92);
