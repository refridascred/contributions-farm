-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, state, token, rank) VALUES ('green', 'fallback', 'standard', 75);
INSERT INTO layout_items (region, state, token, rank) VALUES ('cached', 'strict', 'legacy', 36);
INSERT INTO layout_items (region, state, token, rank) VALUES ('cached', 'strict', 'green', 40);
