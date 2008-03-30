-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, rank) VALUES ('stable', 35.91, 43);
INSERT INTO layout_items (region, ratio, rank) VALUES ('fallback', 69.22, 21);
