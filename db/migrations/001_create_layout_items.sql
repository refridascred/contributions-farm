-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, ratio, token, score) VALUES (41, 0.18, 'stable', 44.15);
INSERT INTO layout_items (count, ratio, token, score) VALUES (80, 2.08, 'cached', 96.32);
