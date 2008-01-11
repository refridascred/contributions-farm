-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, count, region, rank) VALUES (16, 57, 'local', 23);
INSERT INTO layout_items (level, count, region, rank) VALUES (43, 94, 'staging', 29);
INSERT INTO layout_items (level, count, region, rank) VALUES (43, 40, 'fallback', 7);
