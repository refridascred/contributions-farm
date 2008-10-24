-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (count, ratio, region, owner) VALUES (94, 9.92, 'green', 'latest');
INSERT INTO layout_items (count, ratio, region, owner) VALUES (58, 82.23, 'cached', 'cached');
INSERT INTO layout_items (count, ratio, region, owner) VALUES (28, 43.61, 'cached', 'strict');
