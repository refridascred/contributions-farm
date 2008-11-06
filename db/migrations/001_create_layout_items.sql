-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, token, region, rank) VALUES (29, 'edge', 'local', 87);
INSERT INTO layout_items (count, token, region, rank) VALUES (91, 'green', 'legacy', 51);
INSERT INTO layout_items (count, token, region, rank) VALUES (99, 'blue', 'latest', 26);
