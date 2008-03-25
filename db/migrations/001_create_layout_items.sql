-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, region, state, rank) VALUES ('open', 'fallback', 'stable', 38);
INSERT INTO layout_items (token, region, state, rank) VALUES ('local', 'latest', 'fallback', 80);
INSERT INTO layout_items (token, region, state, rank) VALUES ('blue', 'green', 'cached', 55);
