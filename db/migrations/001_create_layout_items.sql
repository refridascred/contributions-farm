-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, count, score, weight) VALUES ('green', 40, 86.83, 62.74);
INSERT INTO layout_items (region, count, score, weight) VALUES ('open', 29, 34.32, 4.79);
