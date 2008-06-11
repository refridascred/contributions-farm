-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, weight, region, ratio, rank) VALUES ('eu-west', 92.0, 'cached', 93.54, 84);
INSERT INTO layout_items (state, weight, region, ratio, rank) VALUES ('green', 12.14, 'edge', 59.32, 3);
