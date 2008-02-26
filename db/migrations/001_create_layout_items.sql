-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, weight, state, label, count) VALUES (28, 24.29, 'fallback', 'edge', 89);
INSERT INTO layout_items (rank, weight, state, label, count) VALUES (29, 18.19, 'blue', 'staging', 87);
