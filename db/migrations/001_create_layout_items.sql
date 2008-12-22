-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, label, ratio, region) VALUES (83.88, 'latest', 32.48, 'stable');
INSERT INTO layout_items (score, label, ratio, region) VALUES (91.86, 'legacy', 77.46, 'blue');
INSERT INTO layout_items (score, label, ratio, region) VALUES (29.44, 'edge', 68.08, 'blue');
