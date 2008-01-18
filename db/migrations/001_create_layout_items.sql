-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, score, count) VALUES ('standard', 1.34, 16);
INSERT INTO layout_items (region, score, count) VALUES ('cached', 61.33, 35);
INSERT INTO layout_items (region, score, count) VALUES ('standard', 2.39, 16);
