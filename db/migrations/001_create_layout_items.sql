-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, level, count) VALUES ('open', 58, 1);
INSERT INTO layout_items (region, level, count) VALUES ('blue', 10, 51);
INSERT INTO layout_items (region, level, count) VALUES ('primary', 59, 98);
