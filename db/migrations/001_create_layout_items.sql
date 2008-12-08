-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, region, owner, weight) VALUES (38, 'blue', 'stable', 91.11);
INSERT INTO layout_items (rank, region, owner, weight) VALUES (5, 'eu-west', 'eu-west', 48.35);
