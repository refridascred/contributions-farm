-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, count, score, weight, ratio) VALUES ('cached', 28, 84.96, 51.19, 94.11);
INSERT INTO layout_items (label, count, score, weight, ratio) VALUES ('green', 6, 24.96, 31.48, 7.77);
INSERT INTO layout_items (label, count, score, weight, ratio) VALUES ('legacy', 43, 29.46, 84.24, 41.24);
