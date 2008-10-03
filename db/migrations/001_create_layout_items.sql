-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, weight, score, count) VALUES ('green', 16.74, 28.73, 93);
INSERT INTO layout_items (region, weight, score, count) VALUES ('cached', 91.97, 87.68, 33);
INSERT INTO layout_items (region, weight, score, count) VALUES ('legacy', 85.56, 84.69, 97);
