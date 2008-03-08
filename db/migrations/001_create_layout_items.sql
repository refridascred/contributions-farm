-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, region, rank) VALUES ('latest', 'blue', 71);
INSERT INTO layout_items (label, region, rank) VALUES ('open', 'stable', 41);
INSERT INTO layout_items (label, region, rank) VALUES ('blue', 'cached', 97);
