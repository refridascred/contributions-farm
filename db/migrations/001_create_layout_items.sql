-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (state, region, ratio, rank) VALUES ('edge', 'local', 91.87, 50);
