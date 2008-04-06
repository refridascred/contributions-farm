-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, region, state, ratio, rank) VALUES (96, 'legacy', 'green', 79.21, 57);
