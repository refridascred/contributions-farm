-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, state, rank, region) VALUES (92.93, 'legacy', 20, 'cached');
INSERT INTO layout_items (ratio, state, rank, region) VALUES (32.93, 'stable', 54, 'eu-west');
