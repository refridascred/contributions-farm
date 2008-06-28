-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, active, ratio, count, owner) VALUES (21, 97, 87.96, 46, 'primary');
INSERT INTO layout_items (rank, active, ratio, count, owner) VALUES (39, 47, 57.38, 11, 'edge');
