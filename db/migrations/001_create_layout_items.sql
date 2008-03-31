-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, rank, state, active) VALUES (2.74, 8, 'standard', 75);
INSERT INTO layout_items (ratio, rank, state, active) VALUES (40.14, 31, 'staging', 39);
INSERT INTO layout_items (ratio, rank, state, active) VALUES (18.33, 83, 'green', 6);
