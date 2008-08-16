-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, region, level, count) VALUES ('open', 'stable', 93, 83);
INSERT INTO layout_items (label, region, level, count) VALUES ('legacy', 'eu-west', 9, 45);
INSERT INTO layout_items (label, region, level, count) VALUES ('stable', 'fallback', 2, 61);
