-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (state, rank, region, ratio) VALUES ('primary', 55, 'open', 48.78);
INSERT INTO layout_items (state, rank, region, ratio) VALUES ('stable', 43, 'green', 76.72);
INSERT INTO layout_items (state, rank, region, ratio) VALUES ('cached', 8, 'stable', 74.53);
