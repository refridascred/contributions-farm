-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, active, weight, region, state) VALUES (74, 47, 72.25, 'strict', 'latest');
INSERT INTO layout_items (rank, active, weight, region, state) VALUES (47, 97, 51.05, 'edge', 'staging');
INSERT INTO layout_items (rank, active, weight, region, state) VALUES (25, 33, 50.86, 'strict', 'local');
