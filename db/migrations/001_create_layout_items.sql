-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, region, score, label) VALUES (21, 'staging', 68.63, 'edge');
INSERT INTO layout_items (count, region, score, label) VALUES (49, 'standard', 43.26, 'strict');
INSERT INTO layout_items (count, region, score, label) VALUES (17, 'blue', 70.05, 'latest');
