-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, count, level, state, region) VALUES (89, 46, 67, 'staging', 'staging');
INSERT INTO layout_items (rank, count, level, state, region) VALUES (61, 70, 92, 'green', 'legacy');
