-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, score, count) VALUES (48.83, 44.81, 5);
INSERT INTO layout_items (ratio, score, count) VALUES (77.26, 47.68, 64);
INSERT INTO layout_items (ratio, score, count) VALUES (23.83, 54.19, 7);
