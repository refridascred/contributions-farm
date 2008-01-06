-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (weight, rank, region, score) VALUES (0.61, 55, 'open', 49.91);
INSERT INTO layout_items (weight, rank, region, score) VALUES (5.51, 93, 'fallback', 42.25);
