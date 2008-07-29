-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, level, region, count) VALUES (2.72, 61, 'primary', 17);
INSERT INTO layout_items (weight, level, region, count) VALUES (27.05, 29, 'open', 66);
INSERT INTO layout_items (weight, level, region, count) VALUES (80.36, 78, 'local', 3);
