-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, level, ratio, weight, owner) VALUES (80.8, 79, 46.72, 65.44, 'staging');
INSERT INTO layout_items (score, level, ratio, weight, owner) VALUES (64.55, 25, 56.0, 91.18, 'latest');
