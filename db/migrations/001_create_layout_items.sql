-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, owner, weight, rank, active) VALUES ('edge', 'fallback', 26.67, 1, 35);
INSERT INTO layout_items (label, owner, weight, rank, active) VALUES ('stable', 'standard', 69.1, 53, 22);
