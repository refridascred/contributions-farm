-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, score, count, weight) VALUES ('latest', 49.54, 93, 92.82);
INSERT INTO layout_items (region, score, count, weight) VALUES ('local', 79.24, 5, 11.66);
