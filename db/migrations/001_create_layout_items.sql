-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, ratio, count) VALUES (67.2, 51.69, 97);
INSERT INTO layout_items (score, ratio, count) VALUES (71.91, 40.58, 52);
INSERT INTO layout_items (score, ratio, count) VALUES (81.94, 7.06, 96);
