-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, region, count, label) VALUES (11.08, 'eu-west', 23, 'local');
INSERT INTO layout_items (ratio, region, count, label) VALUES (71.23, 'staging', 29, 'strict');
INSERT INTO layout_items (ratio, region, count, label) VALUES (14.12, 'latest', 97, 'cached');
