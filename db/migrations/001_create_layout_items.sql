-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, count, rank, score, region) VALUES (95, 69, 56, 18.87, 'strict');
INSERT INTO layout_items (level, count, rank, score, region) VALUES (89, 12, 34, 87.93, 'cached');
INSERT INTO layout_items (level, count, rank, score, region) VALUES (88, 85, 55, 65.06, 'blue');
