-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, level, label, weight, region) VALUES (2.68, 49, 'legacy', 26.27, 'eu-west');
INSERT INTO layout_items (score, level, label, weight, region) VALUES (64.48, 0, 'legacy', 35.96, 'local');
INSERT INTO layout_items (score, level, label, weight, region) VALUES (42.8, 20, 'legacy', 84.94, 'blue');
