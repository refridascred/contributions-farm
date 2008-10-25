-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, rank, score) VALUES (61.39, 4, 80.71);
INSERT INTO layout_items (weight, rank, score) VALUES (21.59, 13, 53.3);
INSERT INTO layout_items (weight, rank, score) VALUES (13.76, 50, 92.35);
