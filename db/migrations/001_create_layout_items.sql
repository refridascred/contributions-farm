-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, region, count, ratio) VALUES ('fallback', 'blue', 93, 36.19);
INSERT INTO layout_items (label, region, count, ratio) VALUES ('stable', 'fallback', 35, 72.17);
INSERT INTO layout_items (label, region, count, ratio) VALUES ('primary', 'eu-west', 61, 31.31);
