-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, weight, score, ratio, label) VALUES (72, 39.24, 74.2, 63.57, 'standard');
INSERT INTO layout_items (level, weight, score, ratio, label) VALUES (26, 40.36, 36.25, 62.91, 'strict');
INSERT INTO layout_items (level, weight, score, ratio, label) VALUES (62, 90.72, 97.28, 50.86, 'primary');
