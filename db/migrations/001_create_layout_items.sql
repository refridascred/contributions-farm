-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, ratio, score, rank, count) VALUES ('edge', 36.44, 98.27, 45, 44);
INSERT INTO layout_items (region, ratio, score, rank, count) VALUES ('eu-west', 37.74, 15.7, 76, 51);
INSERT INTO layout_items (region, ratio, score, rank, count) VALUES ('blue', 29.06, 57.17, 17, 86);
