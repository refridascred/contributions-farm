-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, region, weight, score, owner) VALUES (38, 'latest', 89.47, 41.72, 'cached');
INSERT INTO layout_items (active, region, weight, score, owner) VALUES (53, 'standard', 85.68, 45.27, 'standard');
