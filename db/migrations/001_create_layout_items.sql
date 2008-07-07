-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, level, region, owner) VALUES (57.8, 28, 'stable', 'legacy');
INSERT INTO layout_items (score, level, region, owner) VALUES (39.7, 66, 'open', 'green');
