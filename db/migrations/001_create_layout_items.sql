-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, count, ratio, rank) VALUES ('blue', 78, 68.47, 23);
INSERT INTO layout_items (region, count, ratio, rank) VALUES ('legacy', 72, 44.29, 73);
