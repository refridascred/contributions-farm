-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, score, weight) VALUES (5, 6.19, 42.27);
INSERT INTO layout_items (rank, score, weight) VALUES (81, 3.47, 34.27);
INSERT INTO layout_items (rank, score, weight) VALUES (10, 1.88, 2.56);
