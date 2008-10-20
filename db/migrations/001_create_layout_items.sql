-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, weight, region, owner) VALUES (32, 50.81, 'staging', 'strict');
