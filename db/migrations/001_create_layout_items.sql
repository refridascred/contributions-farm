-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, rank, level, owner) VALUES (59.73, 82, 97, 'stable');
INSERT INTO layout_items (weight, rank, level, owner) VALUES (56.42, 15, 55, 'edge');
