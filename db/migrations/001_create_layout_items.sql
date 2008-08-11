-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, ratio, state, region) VALUES (31, 28.53, 'open', 'primary');
INSERT INTO layout_items (count, ratio, state, region) VALUES (96, 53.49, 'primary', 'latest');
