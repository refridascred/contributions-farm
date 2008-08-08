-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, owner, ratio, rank, weight) VALUES (47, 'fallback', 43.59, 84, 81.4);
INSERT INTO layout_items (level, owner, ratio, rank, weight) VALUES (3, 'blue', 82.53, 66, 50.22);
INSERT INTO layout_items (level, owner, ratio, rank, weight) VALUES (39, 'blue', 95.73, 20, 16.01);
