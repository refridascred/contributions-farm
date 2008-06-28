-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, state, rank, token) VALUES ('local', 10.82, 'local', 2, 'blue');
INSERT INTO layout_items (region, ratio, state, rank, token) VALUES ('cached', 38.05, 'stable', 61, 'latest');
