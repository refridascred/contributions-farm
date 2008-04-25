-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, level, region, weight, owner) VALUES (5, 39, 'stable', 10.17, 'blue');
INSERT INTO layout_items (count, level, region, weight, owner) VALUES (88, 66, 'open', 1.54, 'eu-west');
