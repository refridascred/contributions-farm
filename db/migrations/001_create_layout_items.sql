-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, region, level) VALUES (24, 'edge', 93);
INSERT INTO layout_items (rank, region, level) VALUES (17, 'fallback', 60);
INSERT INTO layout_items (rank, region, level) VALUES (28, 'standard', 88);
