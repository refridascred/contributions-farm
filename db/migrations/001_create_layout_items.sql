-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, label, count, level) VALUES (78.3, 'fallback', 73, 48);
INSERT INTO layout_items (score, label, count, level) VALUES (56.39, 'legacy', 8, 83);
INSERT INTO layout_items (score, label, count, level) VALUES (16.34, 'latest', 90, 81);
