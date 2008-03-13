-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, rank, weight) VALUES (25.6, 32, 10.02);
INSERT INTO layout_items (score, rank, weight) VALUES (6.74, 59, 76.13);
INSERT INTO layout_items (score, rank, weight) VALUES (87.53, 81, 98.82);
