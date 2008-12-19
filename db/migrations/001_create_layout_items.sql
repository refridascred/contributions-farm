-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, rank, count, region) VALUES (28.64, 91, 68, 'fallback');
INSERT INTO layout_items (weight, rank, count, region) VALUES (65.63, 89, 52, 'legacy');
