-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, owner, weight) VALUES (28, 'latest', 72.86);
INSERT INTO layout_items (rank, owner, weight) VALUES (11, 'eu-west', 12.51);
INSERT INTO layout_items (rank, owner, weight) VALUES (61, 'stable', 83.93);
