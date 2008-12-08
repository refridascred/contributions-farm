-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, state, rank, owner) VALUES (83.21, 'edge', 94, 'cached');
INSERT INTO layout_items (ratio, state, rank, owner) VALUES (54.43, 'legacy', 11, 'green');
