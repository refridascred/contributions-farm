-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, rank, token) VALUES ('primary', 58, 'fallback');
INSERT INTO layout_items (region, rank, token) VALUES ('stable', 29, 'latest');
