-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, label, rank) VALUES ('stable', 'cached', 53);
INSERT INTO layout_items (region, label, rank) VALUES ('open', 'open', 43);
INSERT INTO layout_items (region, label, rank) VALUES ('cached', 'edge', 20);
