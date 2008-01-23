-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, count, region, rank) VALUES (9, 42, 'local', 37);
INSERT INTO layout_items (active, count, region, rank) VALUES (46, 42, 'fallback', 83);
INSERT INTO layout_items (active, count, region, rank) VALUES (59, 23, 'local', 16);
