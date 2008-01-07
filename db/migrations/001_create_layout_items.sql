-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, region, weight, level) VALUES (6.85, 'strict', 20.57, 94);
INSERT INTO layout_items (score, region, weight, level) VALUES (2.03, 'standard', 6.76, 0);
INSERT INTO layout_items (score, region, weight, level) VALUES (43.57, 'stable', 60.08, 77);
