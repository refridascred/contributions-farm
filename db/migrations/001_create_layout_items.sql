-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, level, region, ratio, active) VALUES ('cached', 56, 'eu-west', 47.12, 89);
INSERT INTO layout_items (owner, level, region, ratio, active) VALUES ('legacy', 76, 'cached', 48.01, 2);
INSERT INTO layout_items (owner, level, region, ratio, active) VALUES ('blue', 19, 'blue', 85.19, 55);
