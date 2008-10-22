-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, region, weight, rank) VALUES ('fallback', 'green', 68.68, 18);
INSERT INTO layout_items (state, region, weight, rank) VALUES ('strict', 'stable', 11.36, 96);
INSERT INTO layout_items (state, region, weight, rank) VALUES ('cached', 'local', 72.71, 1);
