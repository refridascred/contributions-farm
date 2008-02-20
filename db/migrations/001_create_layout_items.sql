-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, score, owner, level) VALUES (58.43, 42.05, 'strict', 34);
INSERT INTO layout_items (ratio, score, owner, level) VALUES (88.06, 97.87, 'fallback', 18);
INSERT INTO layout_items (ratio, score, owner, level) VALUES (64.53, 64.29, 'strict', 84);
