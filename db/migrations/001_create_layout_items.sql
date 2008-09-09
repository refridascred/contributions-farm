-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, rank, owner) VALUES ('blue', 6.96, 43, 'fallback');
INSERT INTO layout_items (region, ratio, rank, owner) VALUES ('edge', 43.73, 77, 'local');
INSERT INTO layout_items (region, ratio, rank, owner) VALUES ('cached', 23.64, 39, 'fallback');
