-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, weight, count, state, region) VALUES (27, 10.36, 76, 'open', 'edge');
INSERT INTO layout_items (rank, weight, count, state, region) VALUES (41, 46.47, 95, 'eu-west', 'open');
INSERT INTO layout_items (rank, weight, count, state, region) VALUES (10, 9.47, 58, 'latest', 'cached');
