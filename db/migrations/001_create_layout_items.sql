-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, weight, score, ratio) VALUES (87, 59.91, 7.84, 69.07);
INSERT INTO layout_items (rank, weight, score, ratio) VALUES (32, 69.01, 20.34, 81.69);
