-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, count, region, rank, label) VALUES ('edge', 94, 'stable', 7, 'edge');
INSERT INTO layout_items (owner, count, region, rank, label) VALUES ('legacy', 49, 'strict', 2, 'green');
