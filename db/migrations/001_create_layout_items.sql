-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, score, rank, region) VALUES ('edge', 75.29, 82, 'eu-west');
INSERT INTO layout_items (state, score, rank, region) VALUES ('fallback', 53.26, 4, 'green');
