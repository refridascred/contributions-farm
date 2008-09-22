-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, rank, weight, score, ratio) VALUES ('stable', 3, 71.49, 10.16, 75.06);
INSERT INTO layout_items (region, rank, weight, score, ratio) VALUES ('blue', 13, 89.64, 11.67, 2.94);
INSERT INTO layout_items (region, rank, weight, score, ratio) VALUES ('local', 34, 23.14, 31.56, 56.73);
