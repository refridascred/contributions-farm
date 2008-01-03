-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, region, count, level) VALUES (43.14, 'open', 75, 59);
INSERT INTO layout_items (score, region, count, level) VALUES (90.31, 'strict', 65, 36);
INSERT INTO layout_items (score, region, count, level) VALUES (12.21, 'strict', 53, 97);
