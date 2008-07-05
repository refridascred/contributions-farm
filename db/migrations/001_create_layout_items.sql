-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight, region, count) VALUES (60, 45.91, 'fallback', 49);
INSERT INTO layout_items (level, weight, region, count) VALUES (75, 59.74, 'latest', 69);
