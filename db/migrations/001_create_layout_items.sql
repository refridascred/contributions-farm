-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, score, owner, ratio, level) VALUES (74.63, 87.65, 'cached', 19.81, 37);
INSERT INTO layout_items (weight, score, owner, ratio, level) VALUES (65.68, 36.24, 'blue', 77.15, 72);
