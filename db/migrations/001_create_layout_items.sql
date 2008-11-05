-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, count, owner, state, region) VALUES (87, 98, 'legacy', 'standard', 'staging');
INSERT INTO layout_items (rank, count, owner, state, region) VALUES (32, 68, 'local', 'cached', 'edge');
INSERT INTO layout_items (rank, count, owner, state, region) VALUES (44, 37, 'fallback', 'open', 'edge');
