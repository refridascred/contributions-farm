-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, region, token, score, level) VALUES (31, 'stable', 'open', 73.01, 41);
INSERT INTO layout_items (active, region, token, score, level) VALUES (97, 'stable', 'standard', 61.92, 86);
