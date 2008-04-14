-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, region, score, rank) VALUES (89.71, 'staging', 58.9, 28);
INSERT INTO layout_items (ratio, region, score, rank) VALUES (9.04, 'green', 89.97, 12);
