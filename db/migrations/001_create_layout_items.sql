-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (score, count, ratio) VALUES (56.91, 32, 54.25);
INSERT INTO layout_items (score, count, ratio) VALUES (59.27, 82, 78.81);
INSERT INTO layout_items (score, count, ratio) VALUES (28.83, 13, 68.37);
