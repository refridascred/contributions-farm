-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, score, count) VALUES ('eu-west', 72.67, 15.29, 9);
INSERT INTO layout_items (region, ratio, score, count) VALUES ('fallback', 29.53, 11.07, 25);
INSERT INTO layout_items (region, ratio, score, count) VALUES ('eu-west', 0.45, 60.94, 3);
