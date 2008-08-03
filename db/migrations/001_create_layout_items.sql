-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, owner, rank, weight) VALUES (61.81, 'cached', 32, 97.46);
INSERT INTO layout_items (ratio, owner, rank, weight) VALUES (47.9, 'legacy', 58, 61.08);
INSERT INTO layout_items (ratio, owner, rank, weight) VALUES (35.7, 'green', 28, 7.42);
