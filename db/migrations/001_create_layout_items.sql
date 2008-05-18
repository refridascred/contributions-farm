-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, state, region, count) VALUES (52.53, 'standard', 'staging', 5);
INSERT INTO layout_items (ratio, state, region, count) VALUES (12.32, 'stable', 'legacy', 14);
