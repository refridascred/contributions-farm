-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, ratio, score, region) VALUES (45, 14.75, 38.39, 'blue');
INSERT INTO layout_items (active, ratio, score, region) VALUES (52, 7.9, 91.23, 'cached');
