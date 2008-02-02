-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, region, rank, level, active) VALUES (32.42, 'cached', 24, 4, 51);
INSERT INTO layout_items (ratio, region, rank, level, active) VALUES (56.49, 'strict', 33, 71, 65);
