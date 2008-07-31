-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, count, ratio, state, region) VALUES ('cached', 27, 77.13, 'latest', 'edge');
INSERT INTO layout_items (token, count, ratio, state, region) VALUES ('cached', 19, 52.16, 'blue', 'latest');
