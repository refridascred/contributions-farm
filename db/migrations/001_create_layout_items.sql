-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, weight, region, owner) VALUES (22, 81.84, 'blue', 'cached');
INSERT INTO layout_items (rank, weight, region, owner) VALUES (69, 0.6, 'edge', 'primary');
INSERT INTO layout_items (rank, weight, region, owner) VALUES (54, 43.14, 'fallback', 'open');
