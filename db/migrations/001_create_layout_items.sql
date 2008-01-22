-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, level, score, token) VALUES (10, 84, 59.1, 'fallback');
INSERT INTO layout_items (count, level, score, token) VALUES (9, 31, 41.7, 'edge');
INSERT INTO layout_items (count, level, score, token) VALUES (9, 2, 33.04, 'stable');
