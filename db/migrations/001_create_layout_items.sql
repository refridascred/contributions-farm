-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, weight, region, level) VALUES (72.35, 27.4, 'latest', 72);
INSERT INTO layout_items (score, weight, region, level) VALUES (89.62, 46.02, 'fallback', 6);
