-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, level, count) VALUES ('fallback', 13, 35);
INSERT INTO layout_items (region, level, count) VALUES ('standard', 27, 33);
INSERT INTO layout_items (region, level, count) VALUES ('cached', 79, 12);
