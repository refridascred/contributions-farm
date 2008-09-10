-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, level, region, ratio) VALUES (46, 77, 'primary', 41.9);
INSERT INTO layout_items (count, level, region, ratio) VALUES (20, 77, 'latest', 41.16);
