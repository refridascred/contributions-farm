-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, score, region, owner) VALUES (67, 45.42, 'fallback', 'standard');
INSERT INTO layout_items (level, score, region, owner) VALUES (38, 54.77, 'latest', 'edge');
INSERT INTO layout_items (level, score, region, owner) VALUES (64, 61.7, 'blue', 'edge');
