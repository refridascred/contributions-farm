-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, owner, weight, score, region) VALUES (27, 'cached', 57.33, 95.15, 'blue');
INSERT INTO layout_items (count, owner, weight, score, region) VALUES (48, 'cached', 87.01, 63.26, 'cached');
INSERT INTO layout_items (count, owner, weight, score, region) VALUES (61, 'legacy', 74.03, 50.4, 'latest');
