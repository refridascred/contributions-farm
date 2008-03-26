-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, rank, label, active, state) VALUES (27.02, 60, 'primary', 69, 'latest');
INSERT INTO layout_items (ratio, rank, label, active, state) VALUES (92.21, 1, 'eu-west', 72, 'fallback');
INSERT INTO layout_items (ratio, rank, label, active, state) VALUES (57.96, 73, 'local', 0, 'latest');
