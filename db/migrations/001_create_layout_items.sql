-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, level, score, label) VALUES (24.88, 90, 62.8, 'fallback');
INSERT INTO layout_items (ratio, level, score, label) VALUES (89.87, 57, 68.64, 'latest');
