-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, rank, owner) VALUES ('blue', 65, 'legacy');
INSERT INTO layout_items (region, rank, owner) VALUES ('cached', 32, 'standard');
INSERT INTO layout_items (region, rank, owner) VALUES ('legacy', 1, 'latest');
