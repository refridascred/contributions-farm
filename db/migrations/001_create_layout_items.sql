-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, label, ratio, level, count) VALUES ('blue', 'staging', 12.34, 27, 87);
INSERT INTO layout_items (region, label, ratio, level, count) VALUES ('legacy', 'standard', 47.23, 31, 4);
INSERT INTO layout_items (region, label, ratio, level, count) VALUES ('stable', 'green', 0.38, 2, 39);
