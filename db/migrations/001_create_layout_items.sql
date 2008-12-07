-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (score, region, state, count, rank) VALUES (47.48, 'legacy', 'latest', 50, 77);
INSERT INTO layout_items (score, region, state, count, rank) VALUES (5.87, 'eu-west', 'open', 35, 78);
INSERT INTO layout_items (score, region, state, count, rank) VALUES (53.63, 'open', 'legacy', 36, 39);
