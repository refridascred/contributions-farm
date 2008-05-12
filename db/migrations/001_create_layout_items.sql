-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, count, region, level) VALUES (2.65, 82, 'green', 13);
INSERT INTO layout_items (score, count, region, level) VALUES (20.07, 63, 'staging', 42);
INSERT INTO layout_items (score, count, region, level) VALUES (59.51, 98, 'blue', 37);
