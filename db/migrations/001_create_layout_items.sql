-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, state, rank, count) VALUES (68.0, 'blue', 65, 48);
INSERT INTO layout_items (ratio, state, rank, count) VALUES (74.31, 'legacy', 33, 48);
INSERT INTO layout_items (ratio, state, rank, count) VALUES (51.34, 'edge', 95, 14);
