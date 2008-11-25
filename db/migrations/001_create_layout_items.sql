-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, ratio, region, count) VALUES ('stable', 23.96, 'strict', 66);
INSERT INTO layout_items (owner, ratio, region, count) VALUES ('strict', 57.52, 'local', 88);
INSERT INTO layout_items (owner, ratio, region, count) VALUES ('staging', 2.06, 'local', 52);
