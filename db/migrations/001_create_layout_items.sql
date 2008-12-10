-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, count, region, token, score) VALUES (6, 9, 'standard', 'standard', 49.67);
INSERT INTO layout_items (active, count, region, token, score) VALUES (20, 80, 'stable', 'fallback', 58.7);
INSERT INTO layout_items (active, count, region, token, score) VALUES (8, 41, 'open', 'stable', 16.73);
