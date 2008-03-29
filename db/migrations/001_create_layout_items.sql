-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, level, region, rank, active) VALUES ('stable', 47, 'cached', 55, 17);
INSERT INTO layout_items (owner, level, region, rank, active) VALUES ('cached', 94, 'strict', 75, 14);
INSERT INTO layout_items (owner, level, region, rank, active) VALUES ('strict', 98, 'local', 62, 23);
