-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, ratio, level, rank) VALUES ('fallback', 44.63, 27, 15);
INSERT INTO layout_items (region, ratio, level, rank) VALUES ('fallback', 84.54, 82, 18);
INSERT INTO layout_items (region, ratio, level, rank) VALUES ('fallback', 37.16, 72, 93);
