-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (score, ratio, region, active, rank) VALUES (17.32, 47.87, 'standard', 31, 7);
INSERT INTO layout_items (score, ratio, region, active, rank) VALUES (66.08, 76.8, 'legacy', 5, 27);
INSERT INTO layout_items (score, ratio, region, active, rank) VALUES (14.78, 81.14, 'standard', 32, 12);
