-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, score, count) VALUES ('stable', 29.97, 32);
INSERT INTO layout_items (region, score, count) VALUES ('standard', 31.99, 12);
INSERT INTO layout_items (region, score, count) VALUES ('legacy', 47.89, 15);
