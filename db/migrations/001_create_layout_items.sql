-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, active, rank, label) VALUES (52, 23, 26, 'primary');
INSERT INTO layout_items (count, active, rank, label) VALUES (45, 10, 96, 'primary');
INSERT INTO layout_items (count, active, rank, label) VALUES (40, 37, 41, 'edge');
