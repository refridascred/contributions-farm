-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, score, count, owner, weight) VALUES (69, 56.16, 93, 'standard', 83.64);
INSERT INTO layout_items (rank, score, count, owner, weight) VALUES (25, 27.19, 1, 'fallback', 89.14);
