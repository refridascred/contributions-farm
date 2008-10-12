-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, ratio, state) VALUES (20, 61.9, 'legacy');
INSERT INTO layout_items (rank, ratio, state) VALUES (1, 25.5, 'local');
INSERT INTO layout_items (rank, ratio, state) VALUES (91, 63.89, 'primary');
