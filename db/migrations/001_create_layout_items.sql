-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, region, owner, rank, level) VALUES (74, 'standard', 'local', 72, 57);
INSERT INTO layout_items (count, region, owner, rank, level) VALUES (14, 'fallback', 'strict', 6, 38);
INSERT INTO layout_items (count, region, owner, rank, level) VALUES (32, 'cached', 'local', 83, 65);
