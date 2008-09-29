-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, weight, rank, score, label) VALUES ('standard', 17.77, 93, 74.78, 'latest');
