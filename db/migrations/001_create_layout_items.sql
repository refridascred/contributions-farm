-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, ratio, count, region) VALUES (64, 37.7, 80, 'fallback');
INSERT INTO layout_items (level, ratio, count, region) VALUES (92, 25.7, 36, 'legacy');
