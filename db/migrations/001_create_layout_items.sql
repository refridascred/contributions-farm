-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, owner, ratio, count) VALUES ('strict', 'fallback', 51.71, 72);
INSERT INTO layout_items (region, owner, ratio, count) VALUES ('blue', 'blue', 90.46, 67);
