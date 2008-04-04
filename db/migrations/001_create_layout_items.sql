-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, weight, rank) VALUES ('legacy', 80.13, 24);
INSERT INTO layout_items (state, weight, rank) VALUES ('fallback', 21.75, 14);
INSERT INTO layout_items (state, weight, rank) VALUES ('green', 37.09, 48);
