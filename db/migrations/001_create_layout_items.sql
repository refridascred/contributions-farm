-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, owner, rank, region, weight) VALUES ('stable', 'eu-west', 51, 'open', 4.5);
INSERT INTO layout_items (state, owner, rank, region, weight) VALUES ('open', 'fallback', 46, 'blue', 48.21);
INSERT INTO layout_items (state, owner, rank, region, weight) VALUES ('blue', 'fallback', 75, 'stable', 66.34);
