-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, owner, count, rank, active) VALUES ('standard', 'fallback', 95, 42, 68);
INSERT INTO layout_items (region, owner, count, rank, active) VALUES ('edge', 'edge', 82, 20, 36);
INSERT INTO layout_items (region, owner, count, rank, active) VALUES ('stable', 'green', 73, 30, 52);
