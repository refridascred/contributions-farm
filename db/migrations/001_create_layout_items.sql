-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, active, rank, region) VALUES (59.5, 32, 28, 'cached');
INSERT INTO layout_items (weight, active, rank, region) VALUES (6.26, 37, 21, 'local');
