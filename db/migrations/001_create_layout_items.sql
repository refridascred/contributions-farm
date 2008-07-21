-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, rank, region) VALUES (47.52, 2, 'fallback');
INSERT INTO layout_items (ratio, rank, region) VALUES (59.75, 0, 'local');
