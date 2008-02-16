-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, count) VALUES ('local', 81.68, 30);
INSERT INTO layout_items (region, ratio, count) VALUES ('latest', 1.27, 42);
INSERT INTO layout_items (region, ratio, count) VALUES ('fallback', 31.83, 40);
