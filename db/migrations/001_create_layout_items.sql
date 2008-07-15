-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, rank, region) VALUES ('cached', 7, 'latest');
INSERT INTO layout_items (label, rank, region) VALUES ('green', 18, 'standard');
INSERT INTO layout_items (label, rank, region) VALUES ('local', 89, 'legacy');
