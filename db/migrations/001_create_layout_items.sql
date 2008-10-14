-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, region, state, owner) VALUES (67, 'legacy', 'standard', 'standard');
INSERT INTO layout_items (rank, region, state, owner) VALUES (63, 'green', 'staging', 'primary');
INSERT INTO layout_items (rank, region, state, owner) VALUES (61, 'staging', 'latest', 'edge');
