-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, count, score, ratio) VALUES (37.78, 0, 25.69, 86.63);
INSERT INTO layout_items (weight, count, score, ratio) VALUES (87.69, 89, 13.7, 61.12);
INSERT INTO layout_items (weight, count, score, ratio) VALUES (59.43, 37, 71.43, 32.73);
