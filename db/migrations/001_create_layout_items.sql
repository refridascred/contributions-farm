-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, state, region, rank) VALUES (12, 'staging', 'cached', 47);
INSERT INTO layout_items (count, state, region, rank) VALUES (87, 'standard', 'local', 74);
INSERT INTO layout_items (count, state, region, rank) VALUES (79, 'latest', 'legacy', 43);
