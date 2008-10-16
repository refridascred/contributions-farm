-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, region, count, owner, level) VALUES (58, 'strict', 9, 'open', 73);
INSERT INTO layout_items (rank, region, count, owner, level) VALUES (58, 'local', 36, 'strict', 36);
INSERT INTO layout_items (rank, region, count, owner, level) VALUES (70, 'edge', 73, 'edge', 36);
