-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, state, region, rank) VALUES (47.65, 'edge', 'green', 78);
INSERT INTO layout_items (score, state, region, rank) VALUES (87.35, 'legacy', 'latest', 17);
INSERT INTO layout_items (score, state, region, rank) VALUES (69.04, 'fallback', 'legacy', 44);
